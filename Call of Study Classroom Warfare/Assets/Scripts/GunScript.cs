using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public GameObject explosion;
    public AudioClip fireSound;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // playoneshot music.
        if(Input.GetMouseButtonDown(0))
        {
            AudioSource.PlayClipAtPoint(fireSound, transform.position);
        }
    }

    public void FireAnimation()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);
        
    }
}
