using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletScript : MonoBehaviour
{
    public GameObject explosion;
    public AudioSource explosionSound;

    public Text scoreText;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        explosionSound = GetComponent<AudioSource>();
        scoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 4);
        StartCoroutine(delay());
/*        Destroy(transform.gameObject);*/

    }

    // when bullet collides with cube, destroy both
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Enemy"))
        {
            Instantiate(explosion, transform.position, transform.rotation);
            explosionSound.Play();
            score += 10;
            scoreText.text = "Score: " + score.ToString();
            Destroy(collision.gameObject);
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(30);
    }
}
