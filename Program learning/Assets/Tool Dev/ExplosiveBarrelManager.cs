using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//run unityeditors code library only when your in the editor
#if UNITY_EDITOR
using UnityEditor;
#endif
//[ExecuteInEditMode]

public class ExplosiveBarrelManager : MonoBehaviour
{
    public static List<ExplosiveBarrel> alltheBarrels = new List<ExplosiveBarrel>();

    #if UNITY_EDITOR
    private void OnDrawGizmos()
    {
        foreach (ExplosiveBarrel barrel in alltheBarrels)
        {
            if (barrel.type == null) continue;

            Vector3 managerPos = transform.position;
            Vector3 barrelPos = barrel.transform.position;
            float halfHeight = (managerPos.y - barrelPos.y) * 0.5f;
            Vector3 Offset = Vector3.up * halfHeight; 
            Handles.DrawBezier(managerPos,barrelPos , managerPos- Offset,barrelPos + Offset, barrel.type.radiusColor,EditorGUIUtility.whiteTexture,1f);

            //Gizmos.DrawLine(transform.position, barrel.transform.position);
            //Handles.DrawAAPolyLine(transform.position, barrel.transform.position);
        } 
    }
    #endif

}
