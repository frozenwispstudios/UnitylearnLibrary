using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; //import unity editor library


//this script overrides the GUI of the default inspector in this case barreltype scriptable object component

//[CustomEditor(typeof(BarrelType))] //custom editor to barrel type which is a scriptable object
public class EditorTestCode : Editor //inheret from Editor
{
    public enum Things
    {
        test1, test2, test3
    }

    Things thing;
    float somevalue;

    public override void OnInspectorGUI()
    {
        //base.OnInspectorGUI();//call default GUI

        //expilcit positioning using Rect
        //GUI
        //EditorGUI

        //impilcit positioning, auto layout
        //GUILayout
        //EditorGUILayout


        GUILayout.BeginHorizontal();//Horizontal layout function
        //GUILayout.BeginVertical();//Vertical layout function

        GUILayout.Label("Test Label", GUILayout.Width(60));
        if (GUILayout.Button("Test Button")) Debug.Log(thing);
        thing = (Things)EditorGUILayout.EnumPopup(thing);
        //somevalue = GUILayout.HorizontalSlider(somevalue,-1f, 1f);

        GUILayout.EndHorizontal();//the end of Horizontal layout function
        //GUILayout.EndVertical();//the end of Vertical layout function

        //this is the same as using Begin and end Horizintal
        using (new GUILayout.VerticalScope(EditorStyles.helpBox))
        {
            GUILayout.Label("Test Label", GUILayout.Width(60));
            if (GUILayout.Button("Test Button")) Debug.Log(thing);
            thing = (Things)EditorGUILayout.EnumPopup(thing);
            //somevalue = GUILayout.HorizontalSlider(somevalue,-1f, 1f);
        }

        //this is the same as using Begin and end Horizintal
        using (new GUILayout.HorizontalScope(EditorStyles.helpBox))
        {
            GUILayout.Label("Test Label", GUILayout.Width(60));
            if (GUILayout.Button("Test Button")) Debug.Log(thing);
            thing = (Things)EditorGUILayout.EnumPopup(thing);
            //somevalue = GUILayout.HorizontalSlider(somevalue,-1f, 1f);
        }

        GUILayout.Label("Test Label", EditorStyles.boldLabel);
        GUILayout.Space(40);
        EditorGUILayout.ObjectField("TestTitle:", null, typeof(Transform), true);

    }
}