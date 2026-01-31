using UnityEngine;

public class PlayerMovement : Movement
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    protected PlayerData _playerData;

    private void Awake()
    {
        _playerData = GetComponent<PlayerData>();
    }

    protected virtual void Update()
    {
        _direction = new Vector3(Input.GetAxis(HorizontalAxis), 0, Input.GetAxis(VerticalAxis));
    }

    protected virtual void FixedUpdate()
    {
        if (_playerData != null)
        {
            Move(_playerData.SpeedMove);
            Rotate();
        }
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
