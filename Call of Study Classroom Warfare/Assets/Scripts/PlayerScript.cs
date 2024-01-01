using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private int health = 500;
    private int score = 0;
    public Image visor;
    public GameObject flash;
    public Text healthText;
    public Text scoreText;
    public Text LootText;
    public GameObject gun;

    public Button respawnButton;

    public bool enemyDead = false;


    // Start is called before the first frame update
    void Start()
    {
        healthText.text = "Health: " + health.ToString();
        scoreText.text = "Score: " + score.ToString();
        LootText.text = "";

        respawnButton = respawnButton.GetComponent<Button>();
        respawnButton.gameObject.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            gun.GetComponent<GunScript>().FireAnimation();
            Shoot();
        }

        if(health <= 0)
        {
            health = 0;
            healthText.text = "Health: " + health.ToString();
            LootText.text = "Mission Failed";
            
            // set color to red. with alpha 0.5.
            visor.color = new Color(0.8584906f, 0.2509804f, 0.2509804f, 0.5f);
            respawnButton.gameObject.SetActive(true);
        }
    }

    public void decreaseHealth()
    {
        health -= 10;
        print("Health Decreased: " + health);
        healthText.text = "Health: " + health.ToString();
        
        // change visor color to hex #DB4040.
        visor.color = new Color(0.8584906f, 0.2509804f, 0.2509804f, 0.5f);

        Invoke("spark", 0.5f);
                Invoke("resetVisor", 3f);

    }

    public void resetVisor()
    {
        // use #383838for visor color.
        visor.color = new Color(0.2196079f, 0.2196079f, 0.2196079f, 0.5f);
    }

    private void spark(){
        Instantiate(flash, transform.position, Quaternion.identity);
    }

    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            print("Hit: " + hit.transform.name);
            if (hit.transform.tag == "Enemy")
            {
                print("Enemy hit");
                hit.transform.GetComponent<EnemyScript>().dropLoot();
                score += 100;
                scoreText.text = "Score: " + score.ToString();
            }
        }
    }

    public void AquireLoot()
    {
        LootText.text = "Mission Complete";
        visor.color = new Color(0.2196079f, 0.2196079f, 0.2196079f, 0.5f);
    }

    public void Respawn()
    {
        health = 100;
        healthText.text = "Health: " + health.ToString();
        score = 0;
        scoreText.text = "Score: " + score.ToString();
        LootText.text = "";
        respawnButton.gameObject.SetActive(false);
        enemyDead = false;
    }
}