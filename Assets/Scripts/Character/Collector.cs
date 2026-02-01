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
        if (other.TryGetComponent(out Item item))
        {
            if (_playerData.TrySetItem(item))
            {
                if (item.MySpawner != null)
                {
                    item.MySpawner.Occupy(null);
                }

                item.transform.SetParent(transform);
            }
        }
    }
}
