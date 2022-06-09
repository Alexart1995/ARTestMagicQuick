using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        audioData.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
