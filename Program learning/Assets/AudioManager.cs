using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public AudioSource[] sounds;
    [Range(0f, 1f)]
    public float volume;
    [Range(0.1f, 0.5f)]
    public float pitch;

    // Start is called before the first frame update
    void Start()
    {
        //sounds[0].GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
