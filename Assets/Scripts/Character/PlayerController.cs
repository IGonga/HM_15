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
            Debug.Log("Input.GetKeyDown(KeyCode.F");
            if (_playerData.CurrentItem != null)
            {
                Debug.Log("CurrentItem != null");
                _playerData.CurrentItem.Use(gameObject);

                Destroy(_playerData.CurrentItem.gameObject);
                _playerData.ClearItem();
            }
        }
    }
}
