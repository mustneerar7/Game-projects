using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // tract helecopter.
    public GameObject helecopter;
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - helecopter.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = helecopter.transform.position + offset;
    }
}
