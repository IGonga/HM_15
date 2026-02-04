using UnityEngine;

public class SpeedBoostItem : Item
{
    [SerializeField] private float _valueModifire;

    private PlayerController _playerController;

    public override bool TryUse(GameObject target)
    {
        if (target.TryGetComponent<PlayerController>(out _playerController))
        {
            _playerController.ApplySpeedBoost(_valueModifire);
            _playerController.ToggleSpeedEffect(true);

            Debug.Log($"Использова предмет: {Name}");
            Debug.Log($"Скорость увеличена на: x{_valueModifire}");
            Destroy(gameObject);

            return true;
        }

        Debug.Log($"Не удалось использовать предмет: {Name}");
        return false;
    }
}
