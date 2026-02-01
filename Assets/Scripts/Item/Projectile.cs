using UnityEngine;

public class Projectile : Movement
{
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;

    private void Start()
    {
        _direction = transform.forward;
        Destroy(gameObject, _lifeTime);
    }

    private void FixedUpdate() => Move(_speed);
}
