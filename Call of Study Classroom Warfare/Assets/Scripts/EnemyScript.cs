using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Animator anim;
    public GameObject fpsCam;
    public GameObject spark;
    public GameObject loot;

    public AudioClip walkSound;

    public AudioClip attackSound;

    public AudioClip explosionSound;

    void Start()
    {
        anim = GetComponent<Animator>();
        Instantiate(loot, transform.position, Quaternion.identity);
        loot.SetActive(false);
        AudioSource.PlayClipAtPoint(walkSound, transform.position);
    }

    // Update is called once per frame
    void Update()
    {

        // get distance between enemy and player
        float distanceToPlayer = Vector3.Distance(transform.position, fpsCam.transform.position);

        if (distanceToPlayer < 400)
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalk", false);
        }

        if (distanceToPlayer < 200)
        {
            anim.SetBool("isWalk", true);
        }

        // if player is in range of 3 meters, stop walking and start attacking
        if (distanceToPlayer < 3)
        {
            anim.SetBool("isWalk", false);
            anim.SetBool("isAttack", true);

            // Vector3 pos = fpsCam.transform.position;
            // pos.z += -4f;

            // Instantiate(spark, pos, Quaternion.identity);

            // get player script and call decreaseHealth method. call this method every 3 seconds.

            if (fpsCam.GetComponent<PlayerScript>().enemyDead == false)
            {
                // playone shot attack sound.
                AudioSource.PlayClipAtPoint(attackSound, transform.position);
                fpsCam.GetComponent<PlayerScript>().decreaseHealth();
                AudioSource.PlayClipAtPoint(explosionSound, transform.position);
            }
            else
            {
                fpsCam.GetComponent<PlayerScript>().AquireLoot();
            }

        }

        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isAttack", false);
            transform.LookAt(fpsCam.transform);
        }

    }

    public void dropLoot()
    {
        // drop loot
        anim.SetBool("isWalk", false);
        anim.SetBool("isDie", true);

        fpsCam.GetComponent<PlayerScript>().enemyDead = true;

        print("Loot dropped");
        loot.SetActive(true);

        Destroy(gameObject, 5f);
    }
}
