using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "WeaponDB", menuName = "Assets/WeaponDB")]
public class WeaponDatabase : ScriptableObject
{
    public List<WeaponClass> allWeapons;
}
