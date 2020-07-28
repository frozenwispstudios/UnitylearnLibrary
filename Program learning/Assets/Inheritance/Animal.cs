using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public string name;
    public int lives = 3;

    public virtual void makesound()
    {
        Debug.Log("NO SOUND");
    }

    // Start is called before the first frame update
    void Start()
    {
        makesound();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
