using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private float _maxHealth;
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotation;

    private float _currentHealth;

    public float MaxHealth => _maxHealth;
    public float CurrentHealth => _currentHealth;
    public float SpeedMove => _speedMove;
    public float SpeedRotation => _speedRotation;

    public Item CurrentItem { get; private set; }

    private void Awake()
    {
        _currentHealth = MaxHealth;
    }

    public bool TrySetItem(Item newItem)
    {
        if (CurrentItem == null)
        {
            CurrentItem = newItem;
            return true;
        }

        return false;
    }

    public void ClearItem() => CurrentItem = null;

    public void AddHealth(float value)
    {
        if (value < 0)
            return;

        _currentHealth += value;

        if (_currentHealth > _maxHealth)
            _currentHealth = _maxHealth;
    }
}
