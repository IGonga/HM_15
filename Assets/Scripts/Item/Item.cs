using UnityEngine;

public abstract class Item : MonoBehaviour
{
    [SerializeField] private string _name;

    public string Name => _name;

    public abstract bool TryUse(GameObject target);
}
