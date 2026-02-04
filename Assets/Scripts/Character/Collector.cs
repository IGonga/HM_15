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
                item.transform.SetParent(transform);
            }
            else
            {
                Debug.Log($"Не удалось подобрать предмет. У вас уже есть: {item.Name}");
            }
        }
    }
}
