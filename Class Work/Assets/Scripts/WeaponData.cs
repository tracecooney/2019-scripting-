using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponData : ScriptableObject
{
    public Sprite sprite;
    public Color color;
    public GameObject prefab;
    
    public int weaponPower = 10;
}
