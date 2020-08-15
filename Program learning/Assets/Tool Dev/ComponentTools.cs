using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[HelpURL("https://frozenwispstudios.wixsite.com/mysite")] //click the (help/?) button on this component and it will take you to a URL

//[RequireComponent(typeof(scriptname/compoenentname))] // THIS IS SO GOOD make sure when you add this component to any object it will bring any required component with it to that object
[ExecuteInEditMode] // runs this code in the editor with out running unity
public class ComponentTools : MonoBehaviour
{
    [Header("Header Name")]
    public string name;
    [Space] //makes a line of space in the editor between variables
    [TextArea] //makes 
    public string details;
    [Range(0f, 100f)] [Tooltip("Define the health tool tip")] //makes a tooltip for any variable hover over the variable name in editor
    public float health; 
    [HideInInspector]
    public float healthmax;

    [UnityEditor.MenuItem("Tools/DoAThing/Doit")]
    public static void DoAThing()
    {
        print("done");
    }

    public Color color;
}
