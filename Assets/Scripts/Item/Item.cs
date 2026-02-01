using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private string _name;
    [SerializeField] private Item _itemPrefab;

    public Item ItemPrefab => _itemPrefab;

    public abstract void Use(GameObject target);

    public virtual void DisplayInfo()
    {
        Debug.Log($"Применяется предмет: {_name}");
    }
}
