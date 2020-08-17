using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BarrelType : ScriptableObject
{
    [Header("ExplosiveBarrel")]
    [Range(1f, 5f)]
    public float radius = 5;
    public float damage = 10;
    public Color radiusColor;

    //public List<MyClass> thing = new List<MyClass>();
}

[System.Serializable]
public class MyClass
{
   
    public Vector3 pos;
    public Color colour;
}

//Inheritance cant be done with this class below cant be used with class above when displaying data in GUI
[System.Serializable]
public class MyOtherClass : MyClass
{
    public Quaternion rot;
}
