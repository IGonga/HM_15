using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private float _spawnCooldown;
    [SerializeField] private SpawnPoint[] _spawnPoint;
    [SerializeField] private Item[] _itemPrefabs;

    private float _currentSpawnCooldown;

    private void Awake()
    {
        _currentSpawnCooldown = _spawnCooldown;
    }

    protected virtual void Update()
    {
        _currentSpawnCooldown -= Time.deltaTime;

        if (_currentSpawnCooldown <= 0)
        {
            List<SpawnPoint> emptyPoints = GetEmptyPoints();

            if (emptyPoints.Count == 0)
            {
                ResetCooldown();
                return;
            }

            TrySpawnItem(emptyPoints);
        }
    }

    private void TrySpawnItem(List<SpawnPoint> emptyPoints)
    {
        foreach (var point in emptyPoints)
        {
            if (point.IsEmpty)
            {
                Item itemPrefab = _itemPrefabs[Random.Range(0, _itemPrefabs.Length)];
                Item itemInstance = Instantiate(itemPrefab, point.transform.position, Quaternion.identity);

                point.Occupy(itemInstance);

                ResetCooldown();

                Debug.Log($"Заспавнен предмет: {itemPrefab.Name}");
                return;
            }
        }
    }

    private void ResetCooldown()
    {
        _currentSpawnCooldown = _spawnCooldown;
    }

    private List<SpawnPoint> GetEmptyPoints()
    {
        List<SpawnPoint > emptyPoint = new List<SpawnPoint>();

        foreach (var point in _spawnPoint)
        {
            if (point.IsEmpty)
            {
                emptyPoint.Add(point);
            }
        }

        return emptyPoint;
    }
}
