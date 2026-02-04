using UnityEngine;

public class ProjectileItem : Item
{
    private Projectile _movementScript;

    private void Awake()
    {
        _movementScript = GetComponent<Projectile>();
    }

    public override bool TryUse(GameObject target)
    {
        if (target != null && _movementScript != null)
        {
            Launch(target);

            Debug.Log($"Использован предмет: {Name}");
            return true;
        }

        Debug.Log($"Не удалось использовать предмет: {Name}");
        return false;
    }

    private void Launch(GameObject target)
    {
        transform.position = target.transform.position;
        transform.rotation = target.transform.rotation;

        _movementScript.enabled = true;

        transform.parent = null;
        Destroy(this);
    }
}
