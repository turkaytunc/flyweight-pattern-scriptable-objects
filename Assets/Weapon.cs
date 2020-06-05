using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private WeaponStats weaponStats;

    [SerializeField] private int damageAmount;
    [SerializeField] private float attackSpeed;
    [SerializeField] private string impueType;
    [SerializeField] private string weaponName;
    [SerializeField] private string description;

    private void Awake()
    {
        GetComponent<Renderer>().material.color = weaponStats.weaponColor;
    }
}
