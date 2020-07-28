using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//storing data from scene to scene used for mangers
public class SingletonLearn : MonoBehaviour
{
    public static SingletonLearn Instance { get; private set; }

    //values you wish to keep from scene to scene
    public string value = "Singleton value";

    //at the start of the scene check if instance exists or not
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            //dont delete instance when moving from scene to scene
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            //destroy any copys that are not the orginal
            Destroy(gameObject);
        }

        //use any where to access data from the orginal scene to scene instance
        print(SingletonLearn.Instance.value);
    }
}
