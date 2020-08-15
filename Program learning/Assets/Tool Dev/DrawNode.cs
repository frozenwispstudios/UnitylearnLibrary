using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawNode : MonoBehaviour
{
    [SerializeField] private float Radius = 2;
    public Color nodeColor;
    private void OnDrawGizmos()
    {
        Gizmos.color = nodeColor;//new Color32(Red, green, Blue, 170);
        Gizmos.DrawWireSphere(transform.position, Radius);
    }
}
