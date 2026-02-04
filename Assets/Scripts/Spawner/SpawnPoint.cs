using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private Item _item;

    public bool IsEmpty => _item == null || _item.gameObject == null || _item.transform.parent != transform;

    public void Occupy(Item item)
    {
        item.transform.SetParent(transform);
        _item = item;
    }
}
