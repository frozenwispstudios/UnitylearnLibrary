using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class SnapperToolWindow : EditorWindow
{
    [MenuItem("Tools/Snapper")]
    public static void Snapper() => GetWindow<SnapperToolWindow>("SnapperTool");//creates editor Window


    public float gridSize = 1f;
    SerializedObject SO;
    SerializedProperty propGridSize;

    //making sure the GUI in the window editor reacts right away
    void OnEnable()
    {
        SO = new SerializedObject(this);
        propGridSize = SO.FindProperty("gridSize"); //update property with the value/variable girdSize/float

        Selection.selectionChanged += Repaint;//updates GUI to be active
        SceneView.duringSceneGui += DuringSceneGUI;//drawgrid
    }

    void OnDisable()
    {
        Selection.selectionChanged -= Repaint;//updates GUI to be deactive
        SceneView.duringSceneGui -= DuringSceneGUI;
    }

    //drawgrid/draw gizmos/things in the scene
    void DuringSceneGUI(SceneView sceneView)
    {
        //depth check for objects in scene with drawen gizmos
        Handles.zTest = UnityEngine.Rendering.CompareFunction.LessEqual;

        const float gridDrawExtent = 16;
        int lineCount = Mathf.RoundToInt((gridDrawExtent * 2) / gridSize);
        if (lineCount % 2 == 0) lineCount++;
        int halfLineCount = lineCount / 2;

        for (int i = 0; i < lineCount; i++)
        {
            int intOffSet = i - halfLineCount;
            float xCoord = intOffSet * gridSize;
            float zCoord0 = halfLineCount * gridSize;
            float zCoord1 = -halfLineCount * gridSize;


            Handles.DrawAAPolyLine(new Vector3(xCoord, 0f, zCoord0), new Vector3(xCoord, 0, zCoord1));

            Handles.DrawAAPolyLine(new Vector3(zCoord0, 0f, xCoord), new Vector3(zCoord1, 0, xCoord));
        }

        /*
        for (int i = 0; i < 100; i++)
        {
            Handles.DrawLine(new Vector3(0, 0, i), new Vector3(i, 0, 0));
            Handles.DrawLine(new Vector3(0, 0, -i), Vector3.right * -100);

        }*/
    }

    //window buttons/lables and so on
    void OnGUI()
    {
        //must be done in this order for saving and undoing
        SO.Update();//update object
        EditorGUILayout.PropertyField(propGridSize);//get Properties
        SO.ApplyModifiedProperties();//Update Properties

        GUILayout.Label("Snapper");

        using (new EditorGUI.DisabledScope(Selection.gameObjects.Length == 0))
        {
            //snap button
            if (GUILayout.Button("Snap Selected Transform"))
            {
                snapTranSelection();
            }

            if (GUILayout.Button("Snap Selected Rotation"))
            {
                snapRotSelection();
            }
        }
    }

    //button functions
    void snapTranSelection()
    {
        //gets the game objects selected in the scene in the editor 
        foreach (GameObject gameobj in Selection.gameObjects)
        {
            Undo.RecordObject(gameobj.transform, "Undo snap string");

            gameobj.transform.position = gameobj.transform.position.Round(gridSize);
        }
    }

    void snapRotSelection()
    {
        //gets the game objects selected in the scene in the editor 
        foreach (GameObject gameobj in Selection.gameObjects)
        {
            Undo.RecordObject(gameobj.transform, "Undo snap string");
            gameobj.transform.rotation = Quaternion.identity;
        }
    }
}
