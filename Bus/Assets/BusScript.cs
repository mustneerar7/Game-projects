using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BusScript : MonoBehaviour
{
    // variables for the kids.
    public GameObject kidsSet;
    public GameObject kidsSet2;
    public GameObject kidsSet3;
    public GameObject kidsSet4;
    public GameObject kidsSet5;
    public GameObject kidsSet6;

    // variables for the score.
    public Text scoreText;
    int score = 0;

    public Text healthText;
    int health = 50;

    // variables for the stop signs.
    bool enabled = true;
    bool enabled2 = true;
    bool enabled3 = true;
    bool enabled4 = true;
    bool enabled5 = true;
    bool enabled6 = true;

    // Start is called before the first frame update
    void Start()
    {
        // set the score to 0.
        scoreText.text = "Score: " + score.ToString();
        score = 0;

        // set the health to 50.
        healthText.text = "Health: " + health.ToString();
        health = 50;

    }

    // Update is called once per frame
    void Update()
    {
        // make bus move forward and backward with arrow keys.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * 10);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 10);
        }

        // make bus turn left and right with arrow keys.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 100);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 100);
        }

        // make bus honk with H key.
        if (Input.GetKeyDown(KeyCode.H))
        {
            GetComponent<AudioSource>().Play();
        }

        if(score == 30)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }
        if (health == 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
        }

    }

    // when the bus hits a stop sign, the kids will disappear and the score will increase.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("StopSign"))
        {
            if(enabled)
            {
                kidsSet.SetActive(false);
                score += 5;
                scoreText.text = "Score: " + score.ToString();
                enabled = false;
            }


        }
        if (other.CompareTag("StopSign2"))
        {
            if (enabled2)
            {
                kidsSet2.SetActive(false);
                score += 5;
                scoreText.text = "Score: " + score.ToString();
                enabled2 = false;
            }
         
        }
        if (other.CompareTag("StopSign3"))
        {
            if (enabled3)
            {
                kidsSet3.SetActive(false);
                score += 5;
                scoreText.text = "Score: " + score.ToString();
                enabled3 = false;
            }

        }
        if (other.CompareTag("StopSign4"))
        {
            if (enabled4)
            {
                kidsSet4.SetActive(false);
                score += 5;
                scoreText.text = "Score: " + score.ToString();
                enabled4 = false;
            }
        }
        if (other.CompareTag("StopSign5"))
        {
            if (enabled5)
            {
                kidsSet5.SetActive(false);
                score += 5;
                scoreText.text = "Score: " + score.ToString();
                enabled5 = false;
            }
        }
        if (other.CompareTag("StopSign6"))
        {
            if (enabled6)
            {
                kidsSet6.SetActive(false);
                score += 5;
                scoreText.text = "Score: " + score.ToString();
                enabled6 = false;
            }
        }
    }

    // when bus collides with car, health will decrease.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Car"))
        {
            health -= 10;
            healthText.text = "Health: " + health.ToString();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("StopSign"))
        {
        }
    }
}
