using UnityEngine;

public class PlayerController : PlayerMovement
{
    [SerializeField] private GameObject _trailEffect;
    [SerializeField] private ParticleSystem _particleEffect;

    protected override void Update()
    {
        base.Update();
        UseItem();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public void ToggleSpeedEffect(bool isActive)
    {
        if (_trailEffect != null)
        {
            _trailEffect.SetActive(isActive);
        }
    }

    public void ToggleParticleEffect(bool isActive)
    {
        if (_particleEffect != null)
        {
            _particleEffect.Play();
        }
    }

    private void UseItem()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (_playerData.CurrentItem != null)
            {
                _playerData.CurrentItem.Use(gameObject);

                _playerData.ClearItem();
            }
        }
    }


}
