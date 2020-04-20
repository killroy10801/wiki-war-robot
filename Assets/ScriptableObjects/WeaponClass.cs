using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Assets/Weapon")]
public class WeaponClass : ScriptableObject
{
    public string ItemId;
    public string Hardpoint;
    public string Name;
    public string WeaponMode;

    public int Range;
    public int Rounds;
    public int BurstRounds;
    public float ChargeTime;
    public float ReloadTime;
    public float CycleTime;
    public float BurstTime;
    public float RofLow;
    public float RofHigh;
    
    [TextArea]
    public string Desc;
    public Sprite ItemSprite;
    
    
}
