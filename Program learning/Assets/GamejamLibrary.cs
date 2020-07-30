using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamejamLibrary 
{

    //get closest object based off tag
    public static GameObject GetClosestObject(GameObject _self,string _searchObjectsTag)
    {
        float distanceToClosestobject = Mathf.Infinity;
        GameObject closestObject = null;
        Object[] allObjects = GameObject.FindGameObjectsWithTag(_searchObjectsTag);

        foreach (GameObject currentObject in allObjects)
        {
            float distanceToObject = (currentObject.transform.position - _self.transform.position).sqrMagnitude;
            if (distanceToObject < distanceToClosestobject)
            {
                distanceToClosestobject = distanceToObject;
                closestObject = currentObject;
            }
        }
        return closestObject;
    }


}
