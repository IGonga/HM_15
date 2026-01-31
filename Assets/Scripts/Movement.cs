using UnityEngine;

public class Movement : MonoBehaviour
{
    protected Vector3 _direction;

    protected void Move(float speed)
    {
        Vector3 step = _direction.normalized * speed * Time.fixedDeltaTime;
        transform.Translate(step, Space.World);
    }
}
