using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="WeaponStats", menuName = "WeaponStats")]
public class WeaponStats : ScriptableObject
{
    private string weaponName;
    private string weaponDescription;
    private int dropRate;
    private int rarity;

}
