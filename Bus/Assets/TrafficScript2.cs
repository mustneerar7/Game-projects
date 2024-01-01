using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficScript2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(0, 0, 0.05f);
        // reset car position when it reaches the end of the track.
        Vector3 pos = transform.position;
        if (pos.x >= 4f)
        {
            pos.x = -6.44f;
            transform.position = pos;
        }
    }
}
