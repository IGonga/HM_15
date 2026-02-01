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
                Item tempItem = Instantiate(_playerData.CurrentItem);

                tempItem.Use(gameObject);

                _playerData.ClearItem();
            }
            else
            {
                Debug.Log("Предмет отсутствует!");
            }
        }
    }
}
