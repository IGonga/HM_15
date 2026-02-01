using UnityEngine;

public class Collector : MonoBehaviour
{
    private PlayerData _playerData;

    private void Awake()
    {
        _playerData = GetComponent<PlayerData>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Item item = other.GetComponent<Item>();

        if (item != null)
        {
            _playerData.TrySetItem(item.ItemPrefab);

            Destroy(other.gameObject);
        }
    }
}
