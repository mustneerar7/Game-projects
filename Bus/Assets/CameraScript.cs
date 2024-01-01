using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
     public GameObject bus;
 private Vector3 offset;


 // Start is called before the first frame update
 void Start()
 {
     offset = transform.position - bus.transform.position;
 }

 // Update is called once per frame
 void Update()
 {
     transform.position = bus.transform.position + offset;
 }


}
