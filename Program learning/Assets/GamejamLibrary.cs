using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GamejamLibrary 
{
    //Get closest object based off tag
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

    //Get all the childern in a parents first layer hierarchy
    public static GameObject[] GetChilden(GameObject _parentObject)
    {
        GameObject[] childenList;
        childenList = new GameObject[_parentObject.transform.childCount];
        for (int i = 0; i < _parentObject.transform.childCount; i++)
        {
            childenList[i] = _parentObject.transform.GetChild(i).gameObject;
        }

        return childenList;
    }

    public static void AnimationFinish(Animator _animator, string _currentAnimation)
    {
        if (_animator.GetCurrentAnimatorStateInfo(0).IsName(_currentAnimation))
        {
            _animator.SetBool(_currentAnimation, false);
            // animation ends here do what is needed
        }
    }

    //rigidbody functions
    /*public static void SetRigidBodyState(bool state)//Set all chiderns rigidbodys on or off
    {
        Rigidbody[] rigidbodies = GetComponentsInChildren<Rigidbody>();

        foreach (Rigidbody rigidbody in rigidbodies)
        {
            rigidbody.isKinematic = state;
        }

        GetComponent<Rigidbody>().isKinematic = !state;
    }

    public static void SetColliderState(bool state)//Set all chiderns colliders on or off
    {
        Collider[] colliders = GetComponentsInChildren<Collider>();

        foreach (Collider collider in colliders)
        {
            collider.enabled = state;   
        }
        GetComponent<Collider>().enabled = !state;
    }*/

    //change mouse image when hover over a object with name/tag
    public static void ChangeMouseImage(Texture2D _newCusorImage, string _tag = "", string _objectName = "")
    {
        RaycastHit rayHit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out rayHit, Mathf.Infinity))
        {
            if (rayHit.collider.tag == _tag || rayHit.collider.name == _objectName)
            {
                //change mouse cursor
                Cursor.SetCursor(_newCusorImage, Vector2.zero, CursorMode.Auto);
            }
        }
    }

}
