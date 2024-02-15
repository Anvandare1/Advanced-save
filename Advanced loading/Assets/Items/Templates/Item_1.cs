using UnityEngine;
[CreateAssetMenu(fileName = "New Item", menuName = "Loading/Item_1")]
public class Item_1 : Item
{
    public int Stack{get{return stack;}}
    [SerializeField] private int stack; 
}
