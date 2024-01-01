using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    Vector3 offset;
    public GameObject football;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - football.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = football.transform.position + offset;
    }
}
