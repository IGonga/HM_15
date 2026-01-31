using UnityEngine;

public class Movement : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";

    [SerializeField] private float _speed;
    [SerializeField] private float _speedRotation;

    private Vector3 _direction;
    private Vector3 _normalizedDirection;

    private void Update()
    {
        _direction = new Vector3(Input.GetAxis(HorizontalAxis), 0, Input.GetAxis(VerticalAxis));
        _normalizedDirection = _direction.normalized;
    }

    private void FixedUpdate()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        Vector3 step = _normalizedDirection * _speed * Time.fixedDeltaTime;
        transform.Translate(step, Space.World);
    }

    private void Rotate()
    {
        if (_direction.magnitude > 0.01f)
        {
            Quaternion lookRotation = Quaternion.LookRotation(_direction);
            float step = _speedRotation * Time.deltaTime;
            transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, step);
        }
    }
}
