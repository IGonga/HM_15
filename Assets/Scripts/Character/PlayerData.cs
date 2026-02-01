using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotation;

    public float Health => _health;
    public float SpeedMove => _speedMove;
    public float SpeedRotation => _speedRotation;

    public Item CurrentItem { get; private set; }

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
}
