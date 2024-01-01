using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudoController : MonoBehaviour
{
    public Button muteButton;
    public AudioSource gameAudio;
    // Start is called before the first frame update
    void Start()
    {
        gameAudio = GetComponent<AudioSource>();
        muteButton = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void muteGame(){
        gameAudio.mute = gameAudio.mute ? false : true;
        muteButton.text = gameAudio.mute ? "Unmute" : "Mute";
    }
}
