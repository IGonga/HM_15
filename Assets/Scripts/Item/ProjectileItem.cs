    using UnityEngine;

public class ProjectileItem : Item
{
    [SerializeField] private Projectile _projectilePrefab;

    public override void Use(GameObject target)
    {
        DisplayInfo();

        _projectilePrefab.enabled = true;

        Instantiate(_projectilePrefab, target.transform.position, target.transform.rotation);
    }
}
