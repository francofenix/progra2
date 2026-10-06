using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Scriptables/Item")]

public class Items : ScriptableObject
{
    public string itemName;
    public string itemDescription;
    public Color32 color;


}
