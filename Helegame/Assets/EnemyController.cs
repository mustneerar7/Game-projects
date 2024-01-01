using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(enemy, new Vector3(Random.Range(200,400), Random.Range(77, 78), Random.Range(36, 76)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
