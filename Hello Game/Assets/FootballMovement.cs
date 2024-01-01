using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootballMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // movement using wasd keys.
        if(Input.GetKey("w")){
            transform.Translate(0,0,0.5f);
        } else if(Input.GetKey("s")){
            transform.Translate(0,0,-0.5f);
        } else if(Input.GetKey("a")){
            transform.Translate(-0.5f,0,0);
        } else if(Input.GetKey("d")){
            transform.Translate(0.5f,0,0);
        }

        // movement using arrow keys
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0,0,0.5f);
        } else if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0,0,-0.5f);
        } else if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-0.5f,0,0);
        } else if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(0.5f,0,0);
        }

        // move the football with screen swipes
        if(Input.touchCount > 0){
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved){
                transform.Translate(touch.deltaPosition.x * 0.01f, 0, touch.deltaPosition.y * 0.01f);
            }
        }

        // use accelerometer to move the football
        transform.Translate(Input.acceleration.x * 0.5f, 0, Input.acceleration.y * 0.25f);
    }
}
