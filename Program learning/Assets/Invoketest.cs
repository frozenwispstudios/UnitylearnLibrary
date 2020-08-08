using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoketest : MonoBehaviour
{
    public GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Create",2f); //does it once
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("Create",2f); //keeps doing it
    }

    void Create()
    {
        Instantiate(test);
        print("CREATE");
    }
}
