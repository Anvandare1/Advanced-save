using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Loading/Item")]
public class Item : ScriptableObject
{
    public string ID{get{return id;}}
    public string Name{get{return name;}}
    [SerializeField] private string id;
    [SerializeField] private new string name;
}
