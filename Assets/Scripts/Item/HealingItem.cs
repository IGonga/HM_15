using UnityEngine;

public class HealingItem : Item
{
    [SerializeField] private float _value;

    public override bool TryUse(GameObject target)
    {
        if (target.TryGetComponent<PlayerData>(out PlayerData playerData))
        {
            if (target.TryGetComponent<PlayerController>(out PlayerController playerController))
                playerController.ToggleParticleEffect(true);

            playerData.AddHealth(_value);

            Debug.Log($"Использован предмет: {Name}");
            Debug.Log($"Получено исцеление на {_value} HP");
            Debug.Log($"Текущее здоровье: {playerData.CurrentHealth}/{playerData.MaxHealth} HP");

            Destroy(gameObject);

            return true;
        }

        Debug.Log($"Не удалось использовать предмет: {Name}");
        return false;
    }
}
