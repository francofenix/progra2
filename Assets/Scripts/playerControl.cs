using UnityEngine;

public class playerControl : MonoBehaviour
{
    public bool inventoryOpened = false;

    public GameObject inventory;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inventoryOpened == false)
        {
            inventory.SetActive(true);
            inventoryOpened = true;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && inventoryOpened == true)
        {
            inventory.SetActive(false);
            inventoryOpened = false;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
    }
}
