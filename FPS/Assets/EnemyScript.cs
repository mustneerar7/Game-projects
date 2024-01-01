using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("isDead", false);
        anim.SetBool("isWalk", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // on collision with bullet
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.StartsWith("Bullet"))
        {
   
            //destroy bullet
            Destroy(collision.gameObject);
            anim.SetBool("isDead", true);
        }
    }

    public void die()
    {
        anim.SetBool("isDead", true);
        
    }
}
