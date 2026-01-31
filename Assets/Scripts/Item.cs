using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private string _name;

    protected abstract void Use();

    protected virtual void DisplayInfo()
    {
        Debug.Log($"Название предмета: {_name}");
    }
}
