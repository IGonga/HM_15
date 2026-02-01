using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnCooldown;
    [SerializeField] private Transform _spawnPoint;

    private float _currentSpawnCooldown;

    public float CurrentSpawnCooldown => _currentSpawnCooldown;

    private Item _item;

    public bool IsEmpty => _item == null;

    public Vector3 SpawnPosition => _spawnPoint != null ? _spawnPoint.position : transform.position;

    private void Awake()
    {
        _currentSpawnCooldown = _spawnCooldown;
    }

    protected virtual void Update()
    {
        if (IsEmpty == true)
        {
            _currentSpawnCooldown -= Time.deltaTime;
        }
    }

    public void Occupy(Item item)
    {
        _item = item;
    }

    public void ResetCooldown()
    {
        _currentSpawnCooldown = _spawnCooldown;
    }
}
