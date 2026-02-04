using UnityEngine;

public class HealingItem : Item
{
    [SerializeField] private float _value;

    public override void Use(GameObject target)
    {
        if (target.TryGetComponent<PlayerData>(out PlayerData playerData))
        {
            if (target.TryGetComponent<PlayerController>(out PlayerController playerController))
                playerController.ToggleParticleEffect(true);

            playerData.CurrentHealth = _value;

            DisplayInfo();

            Destroy(gameObject);
        }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();

        Debug.Log($"Получено исцеление на {_value} ХП");
    }
}
