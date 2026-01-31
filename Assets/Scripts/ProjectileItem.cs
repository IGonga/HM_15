using UnityEngine;

public class ProjectileItem : Item
{
    [SerializeField] private Projectile _projectilePrefab;

    public override void Use(GameObject target)
    {
        DisplayInfo();

        Instantiate(_projectilePrefab, target.transform.position, target.transform.rotation);
    }
}
