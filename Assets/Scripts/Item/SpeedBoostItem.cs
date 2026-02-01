using UnityEngine;

public class SpeedBoostItem : Item
{
    [SerializeField] private float _valueModifire;
    [SerializeField] private float _durationOfAction;

    private PlayerController _playerController;
    private bool _isActive = false;

    public override void Use(GameObject target)
    {
        if (target.TryGetComponent<PlayerController>(out _playerController))
        {
            _isActive = true;
            _playerController.ApplySpeedBoost(_valueModifire);

            DisplayInfo();
        }
        else
            Debug.Log("Не удалось использовать предмет.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();

        Debug.Log($"Скорость увеличена на: x{_valueModifire}");
        Debug.Log($"Продолжительность: {_durationOfAction} сек.");
    }

    private void Update()
    {
        if (_isActive)
        {
            if (_durationOfAction < 0)
                Dispose();

            _durationOfAction -= Time.deltaTime;
        }
    }

    private void Dispose()
    {
        _playerController.ResetSpeed();

        Debug.Log($"Предмет деактивирован.");

        Destroy(gameObject);
    }
}
