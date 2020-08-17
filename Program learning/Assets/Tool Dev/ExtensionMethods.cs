using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//static functions for barrel tool dev test
public static class ExtensionMethods 
{
    //extension method of the funtion Round
    public static Vector3 Round(this Vector3 v)
    {
        v.x = Mathf.Round(v.x);
        v.y = Mathf.Round(v.y);
        v.z = Mathf.Round(v.z);
        return v;
    }

    //grid with a set size
    public static Vector3 Round(this Vector3 v, float size)
    {
        return (v / size).Round() * size;
    }
}
