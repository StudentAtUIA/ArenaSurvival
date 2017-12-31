using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName ="Inventory/Item")] //Creating new items

public class Item : ScriptableObject {

    public string Itemname = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;

    public virtual void Use()
    {
        Debug.Log("using" + name);
    }

    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
    }
}
