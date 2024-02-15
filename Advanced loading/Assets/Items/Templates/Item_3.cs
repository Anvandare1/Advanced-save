using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Loading/Item_3")]
public class Item_3 : Item
{
    public float No{get{return no;}}
    [SerializeField] private float no; 
}