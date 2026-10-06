using UnityEngine;

public class playerMovement : MonoBehaviour
{

    float movementSpeed = 3,
          verticalRotation;

    float mouseSens = 100f;

    Transform camTrans;
    Rigidbody rb;

    playerCollisions playercol;
    playerControl control;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody>();

        playercol = GetComponent<playerCollisions>();
        control = GetComponent<playerControl>();

        camTrans = GetComponentInChildren<Camera>().transform;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        MovementManager();
        CameraMovement();
        Jump();
    }

    void MovementManager()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float verticalInput = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        if (control.inventoryOpened == false)
        {
            transform.Translate(horizontalInput * movementSpeed, 0, verticalInput * movementSpeed);
        }
    }

    void CameraMovement()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * mouseSens;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * mouseSens;

        if (control.inventoryOpened == false)
        {
            verticalRotation -= mouseY;
            verticalRotation = Mathf.Clamp(verticalRotation, -90, 90);

            transform.Rotate(0, mouseX, 0);
            camTrans.localEulerAngles = new Vector3(verticalRotation, 0, 0);
        }
    }

    void Jump()
    {
        float jumpForce = 5;
        if (playercol.onFloor == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }



  
}
