using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponStats weaponStats;

    private int damageAmount;
    private float attackSpeed;
    private string impueType;


    private void Awake()
    {
        GetComponent<Renderer>().material.color = weaponStats.weaponColor;
    }
}
