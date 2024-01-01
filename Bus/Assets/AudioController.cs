using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudoController : MonoBehaviour
{
    public AudioSource gameAudio;
    // Start is called before the first frame update
    void Start()
    {
        gameAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // if bus moves, play the audio.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameAudio.Play();
        }
    }
}
