using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BarrelType : ScriptableObject
{
    [Header("ExplosiveBarrel")]
    [Range(1f, 5f)]
    public float Radius = 5;
    public float Damage = 10;
    public Color radiusColor;
}
