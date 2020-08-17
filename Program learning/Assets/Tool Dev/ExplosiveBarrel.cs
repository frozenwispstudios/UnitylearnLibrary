using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ExplosiveBarrel : MonoBehaviour
{
    public BarrelType type;

    private void Awake()
    {
        //GetComponent<MeshRenderer>().material.color = type.radiusColor; //makes new material and changes colour //error with this but im lazy
        GetComponent<MeshRenderer>().sharedMaterial.color = type.radiusColor; //modify current materials colour
    }


    private void OnDrawGizmosSelected() // only show when selected (OnDrawGizmos) this will keep the gizmos showing constant
    {
        if (type == null) return;
        type.radiusColor.a = 1;
        Gizmos.color = type.radiusColor;
        Gizmos.DrawWireSphere(transform.position, type.radius);
        GetComponent<MeshRenderer>().sharedMaterial.color = type.radiusColor;
        //GetComponent<MeshRenderer>().material.color = type.radiusColor;
    }

    //when enabled add to manager when disabled remove from manager
    private void OnEnable()
    {
        if (type == null) return;
        ExplosiveBarrelManager.alltheBarrels.Add(this); //adds self to game manager instead of manager getting in
        //GetComponent<MeshRenderer>().material.color = type.radiusColor;
    }

    private void OnDisable()
    {
        if (type == null) return;
        ExplosiveBarrelManager.alltheBarrels.Remove(this); //adds self to game manager instead of manager getting in
    }

}
