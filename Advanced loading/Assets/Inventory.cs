using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    [SerializeField] private Text inventorycontents;
    public List<Item> Itemlist{get{return itemlist;}set{itemlist = value;}}
    List<Item> itemlist = new List<Item>();

    private AvailableItems availableItems;

    void Start()
    {
        availableItems = GameObject.FindWithTag("GameManager").GetComponent<AvailableItems>();
    }
    void Update()
    {
        string value = "";
        foreach(Item item in itemlist)
        {
            value += item.Name + " ";
            switch(item)
            {
                case Item_1:
                  Item_1 tempitem = (Item_1)item;
                  value += "Stack: " + tempitem.Stack + "\n";
                break;

                case Item_2:
                  Item_2 tempitem2 = (Item_2)item;
                  value += "Bool: " + tempitem2.Yes + "\n";
                break;

                case Item_3:
                  Item_3 tempitem3 = (Item_3)item;
                  value += "Float: " + tempitem3.No + "\n";
                break;
            }
        }
        inventorycontents.text = value;
    } 

    public void AddRandomItem()
    {
        int i = Random.Range(0, availableItems.Items.Count - 1);
        itemlist.Add(availableItems.Items[i]);
    }

    public void ClearInventory()
    {
        itemlist.Clear();
    }
}
