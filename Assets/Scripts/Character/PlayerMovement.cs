using UnityEngine;

public class PlayerMovement : Movement
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    private float _baseSpeedModifire = 1f;
    private float _currentSpeedModifire;

    protected PlayerData _playerData;

    private void Awake()
    {
        _playerData = GetComponent<PlayerData>();
        _currentSpeedModifire = _baseSpeedModifire;
    }

    protected virtual void Update()
    {
        _direction = new Vector3(Input.GetAxis(HorizontalAxis), 0, Input.GetAxis(VerticalAxis));
    }

    protected virtual void FixedUpdate()
    {
        if (_playerData != null)
        {
            Move(_playerData.SpeedMove * _currentSpeedModifire);
            Rotate();
        }
    }

    public void ApplySpeedBoost(float multiplier)
    {
        if (multiplier > 0)
            _currentSpeedModifire += multiplier;
    }

    public void ResetSpeed()
    {
        _currentSpeedModifire = _baseSpeedModifire;
    }

    private void Rotate()
    {
        if (_direction.magnitude > 0.01f)
        {
            Quaternion lookRotation = Quaternion.LookRotation(_direction);
            float step = _playerData.SpeedRotation * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
        }
    }
}
