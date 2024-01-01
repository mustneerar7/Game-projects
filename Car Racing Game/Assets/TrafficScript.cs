using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, 0.05f);
        // reset car position when it reaches the end of the track.
        Vector3 pos = transform.position;
        if(pos.z >=75){
            pos.z = -93;
            transform.position = pos;
        }
    }
}
