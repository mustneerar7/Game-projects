using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour
{
    public Text scoreText;
    public Text fuelText;
    int score = 0;
    int fuel = 100;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        fuelText.text = "Fuel: " + fuel.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // move car forward using arrow keys
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0, 0.8f);

            score += 1;
            fuel -= 1;
            scoreText.text = "Score: " + score.ToString();
            fuelText.text = "Fuel: " + fuel.ToString();
        }

        // move car backward using arrow keys
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 250);
        }

        // rotate car left using arrow keys
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 250);
        }

        // rotate car right using arrow keys
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 250);
        }

        // reset car position when it reaches the end of the track.
        Vector3 pos = transform.position;
        if (pos.z >= 75)
        {
            pos.z = -93;
            transform.position = pos;
        }

        // if fuel value is zero. load the game over scene.
        if (fuel <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    // reset fuel value on collision with fuel drum.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("FuelDrum"))
        {
            fuel = 100;
            fuelText.text = "Fuel: " + fuel.ToString();
        }
    }
}
