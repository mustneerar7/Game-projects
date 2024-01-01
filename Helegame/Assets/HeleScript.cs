using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeleScript : MonoBehaviour
{
    public GameObject bullet;
    public AudioClip bulletFire;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().clip = bulletFire;
    }

    // Update is called once per frame
    void Update()
    {
        // helecopter move up and down by arrow keys.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, 0.8f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -0.8f, 0);
        }

        // helecopter move forward and backward by w and s keys.
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, 0.8f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.8f);
        }

        // helecopter turn left and right by a and d keys.
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -4, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 4, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 helipos = transform.position;
            helipos.y -= 1;
            Instantiate(bullet, helipos, transform.rotation);
            GetComponent<AudioSource>().PlayOneShot(bulletFire);
        }
    }

    // if helecopter collide with enemy, game over.
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Enemy"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
