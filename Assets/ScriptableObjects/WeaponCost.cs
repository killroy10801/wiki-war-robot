using UnityEngine;

[CreateAssetMenu(fileName = "WeaponCost", menuName = "Assets/WeaponCost")]
public class WeaponCost : ScriptableObject
{
    public string ItemId;
    public int Cost;
    public string Time;
    public float Damage;
    public string CostType;
    public bool MK2;
    public int Level;

}
