using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Loading/Item_2")]
public class Item_2 : Item
{
    public bool Yes{get{return yes;}}
    [SerializeField] private bool yes; 
}