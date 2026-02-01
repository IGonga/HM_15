using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : Spawner
{
    [SerializeField] private List<Item> _randomItem;

    protected override void Update()
    {
        base.Update();

        if (CurrentSpawnCooldown < 0 && IsEmpty)
        {
            SpawnItem();
            ResetCooldown();
        }
    }

    private void SpawnItem()
    {
        Item item = Instantiate(_randomItem[Random.Range(0, _randomItem.Count)], SpawnPosition, Quaternion.identity);
        item.MySpawner = this;
        Occupy(item);
    }
}
