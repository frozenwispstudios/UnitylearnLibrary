using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static class SnapperTool
{
    const string UNDO_STR_SNAP = "Undo snap objects";

    //[MenuItem("Edit/Snap Selected Objects %&S", isValidateFunction: true)] // adds a button at the bottom of the Edit menu in unity/ runs function code
    // %&S is CTRL + ALT + S it needs a space at the beginning

    [MenuItem("MyCode/Snap Selected Objects %&S", isValidateFunction: true)] // adds a button at the bottom of the Edit menu in unity/ runs function code
    //check if you have selected objects in the editor
    public static bool SnapObjectsValidate()
    {
        return Selection.gameObjects.Length > 0;
    }

    [MenuItem("MyCode/Snap Selected Objects %&S")]
    public static void SnapObjects()//this is a Validate Function for the funciton above
    {
        //gets the game objects selected in the scene in the editor 
        foreach(GameObject gameobj in Selection.gameObjects)
        {
            Undo.RecordObject(gameobj.transform, UNDO_STR_SNAP);

            gameobj.transform.position = gameobj.transform.position.Round();
        }
    }
}
