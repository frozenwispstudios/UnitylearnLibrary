using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; //import unity editor library


//this script overrides the GUI of the default inspector in this case barreltype scriptable object component

[CanEditMultipleObjects]
[CustomEditor(typeof(BarrelType))] //custom editor to barrel type which is a scriptable object
public class BarrelTypeEditor : Editor //inheret from Editor
{
    //This is to set up undo and edit mutiple at once
    SerializedObject SO;
    SerializedProperty propRadius;
    SerializedProperty propDamage;
    SerializedProperty propColor;

    void OnEnable()
    {
        SO = serializedObject;
        propRadius = SO.FindProperty("radius");
        propDamage = SO.FindProperty("damage");
        propColor = SO.FindProperty("radiusColor");
    }

    public override void OnInspectorGUI()
    {
        BarrelType barrel = target as BarrelType;

        //GUILayout.Label("Radius: " + barrel.Radius.ToString());
        
        //this is so it can be (control + Z / Undo)
        SO.Update();
        EditorGUILayout.PropertyField(propRadius);
        EditorGUILayout.PropertyField(propDamage);
        EditorGUILayout.PropertyField(propColor);

        SO.ApplyModifiedProperties();
    }
}
