using UnityEngine;
using System.Collections.Generic;

public class AvailableItems : MonoBehaviour
{
    public List<Item> Items {get{return items;}}
    [SerializeField] private List<Item> items = new List<Item>(); 
}
