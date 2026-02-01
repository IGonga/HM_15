using UnityEngine;

public class SpeedBoostItem : Item
{
    [SerializeField] private float _valueModifire;

    private PlayerController _playerController;

    public override void Use(GameObject target)
    {
        if (target.TryGetComponent<PlayerController>(out _playerController))
        {
            _playerController.ApplySpeedBoost(_valueModifire);

            DisplayInfo();

            Dispose();
        }
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();

        Debug.Log($"Скорость увеличена на: x{_valueModifire}");
    }

    public override void Dispose()
    {
        Destroy(gameObject);
    }
}
