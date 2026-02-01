using UnityEngine;

public class HealingItem : Item
{
    [SerializeField] private float _value;

    private PlayerData _playerData;

    public override void Use(GameObject target)
    {
        if (target.TryGetComponent<PlayerData>(out _playerData))
        {
            _playerData.CurrentHealth = _value;

            DisplayInfo();

            Dispose();
        }
    }

    public override void Dispose()
    {
        Destroy(gameObject);
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();

        Debug.Log($"Получено исцеление на {_value} ХП");
    }
}
