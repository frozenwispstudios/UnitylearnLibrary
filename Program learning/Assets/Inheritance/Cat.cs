using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    private void Start()
    {
        name = "cat";
    }

    public override void makesound()
    {
        Debug.Log("Meow");
    }

    public void catthing()
    {
        //do a cat thing differnt to other animals
    }
}
