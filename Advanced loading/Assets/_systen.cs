using UnityEngine;
using System;
using System.Collections.Generic;
using System.IO;

public class _systen : MonoBehaviour
{
    Inventory inventory;
    AvailableItems availableitems;
    void Start()
    {
        inventory = GameObject.FindWithTag("Player").GetComponent<Inventory>();
        availableitems = GameObject.FindWithTag("GameManager").GetComponent<AvailableItems>();

        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\Savedata.saf";
        BinaryReader br = new BinaryReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));

        List<Item> templist = new List<Item>();
        int tempi = br.ReadInt32();
        for(int i = 0; i < tempi; i++)
        {
            string tempid = br.ReadString();
            foreach(Item item in availableitems.Items)
            {
                if(item.ID == tempid)
                {
                    templist.Add(item);
                    break;
                }
            }
        }
        br.Close();

        inventory.Itemlist = templist;
    }
    public void Save()
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+@"\Savedata.saf";
        BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write));
        bw.Write(inventory.Itemlist.Count);
        foreach(Item item in inventory.Itemlist)
        {
            bw.Write(item.ID);
        }
        bw.Close();
    }
}
