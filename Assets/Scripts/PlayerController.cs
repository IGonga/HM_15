using UnityEngine;

public class PlayerController : PlayerMovement
{
    protected override void Update()
    {
        base.Update();
        UseItem();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
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
            else
            {
                Debug.Log("Предмет отсутствует!");
            }
        }
    }
}
