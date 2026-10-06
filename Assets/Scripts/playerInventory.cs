using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerInventory : MonoBehaviour
{

    public Image slot1;
    public Image slot2;
    public Image slot3;

    public List<Items> inventoryList = new List<Items>();

    private void Start()
    {
        inventoryList.Clear();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<itemData>())
        {
            inventoryList.Add(other.GetComponent<itemData>().ItemData);
            Destroy(other.gameObject);

            slot1.color = other.GetComponent<itemData>().ItemData.color;
        }
    }
}
