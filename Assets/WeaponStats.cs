﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="WeaponStats", menuName = "WeaponStats")]
[System.Serializable]
public class WeaponStats : ScriptableObject
{
    public int dropRate;
    public int rarity;
    public Color32 weaponColor;
}
