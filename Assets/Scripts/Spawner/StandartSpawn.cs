using UnityEngine;

public class StandartSpawn : Spawner
{
    [SerializeField] private Item _itemPrefab;

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
        Item item = Instantiate(_itemPrefab, SpawnPosition, Quaternion.identity);
        item.MySpawner = this;
        Occupy(item);
    }
}
