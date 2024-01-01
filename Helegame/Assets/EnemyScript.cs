using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject heli;
    public AudioClip explosion;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>().clip = explosion;
    }

    // Update is called once per frame
    void Update()
    {
        // move enemy forward
        transform.Translate(0, 0, 0.2f);
        transform.LookAt(heli.transform);
    }

    // if this enemy collide with anything, play explosion sound.
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Bullet"))
        {
            GetComponent<AudioSource>().PlayOneShot(explosion);
        }
    }
}
