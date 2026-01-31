using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [SerializeField] private float _health;
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotation;

    public float Health => _health;
    public float SpeedMove => _speedMove;
    public float SpeedRotation => _speedRotation;
}
