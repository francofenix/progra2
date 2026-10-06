using UnityEngine;

public class playerCollisions : MonoBehaviour
{
    public bool onFloor;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("floor"))
        {
            onFloor = true;
        }

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("floor"))
        {
            onFloor = false;
        }
    }
}
