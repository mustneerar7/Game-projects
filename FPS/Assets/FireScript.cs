using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject fpsCam;
    public float range = 500;
    public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        // anim = GetComponent<Animator>();
        // anim.SetBool("isDead", false);
    }

    // Update is called once per frame
    void Update()
    {
        // instantiate bullet on b key press
        // if (Input.GetKeyDown(KeyCode.B))
        // {
        //     Instantiate(bullet, transform.position, transform.rotation);            
        // }

        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
            // bullet.SetActive(true);
            // Instantiate(bullet, transform.position, transform.rotation);
        }
    }

    public void Shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {

            if(hit.transform.tag == "enemy")
            {
                print("Cast hit enemy");
                Destroy(enemy);
            }
        }
    }
}
