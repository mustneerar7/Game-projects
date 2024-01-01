using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    public GameObject muteButton;
    public GameObject unmuteButton;

    public static bool muteFlag;
    public static bool unmuteFlag;
    public AudioSource gameaudio;

    // Start is called before the first frame update
    void Start()
    {
        gameaudio = GetComponent<AudioSource>();

        if (muteFlag == true)
        {
            gameaudio.mute = true;
/*            muteButton.SetActive(false);*/
        }

        if (muteFlag == false)
        {
            gameaudio.mute = false;
/*            unmuteButton.SetActive(true);*/
        }

    }

    public void muteGame()
    {
        gameaudio.mute = true;
        muteFlag = true;
        unmuteFlag = false;
/*        unmuteButton.SetActive(true);
        muteButton.SetActive(false);*/
    }

    public void unmuteGame()
    {
        if (muteFlag == true)
        {
            gameaudio.mute = false;
            unmuteFlag = true;
            muteFlag = false;
/*            unmuteButton.SetActive(false);
            muteButton.SetActive(true);*/
        }
    }
}
