using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public void Start()
    {
        name = "dog";
    }


    public override void makesound()
    {
        
        Debug.Log("Woof");
    }

    public void dogthing()
    {
        //do a dog thing differnt to other animals
    }
}
