using UnityEngine;

public class ProjectileItem : Item
{
    private Projectile _movementScript;

    private void Awake()
    {
        _movementScript = GetComponent<Projectile>();
    }

    public override void Use(GameObject target)
    {
        DisplayInfo();

        transform.position = target.transform.position;
        transform.rotation = target.transform.rotation;

        if (_movementScript != null)
            _movementScript.enabled = true;

        transform.parent = null;
        Destroy(this);
    }
}
