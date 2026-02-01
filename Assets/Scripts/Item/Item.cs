using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private string _name;

    public Spawner MySpawner { get; set; }

    public abstract void Use(GameObject target);
    public abstract void Dispose();

    public virtual void DisplayInfo()
    {
        Debug.Log($"Применяется предмет: {_name}");
    }
}
