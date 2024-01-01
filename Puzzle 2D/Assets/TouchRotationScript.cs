using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchRotationScript : MonoBehaviour
{
    private void Start()
    {
        // ControllerScript.youWin = false;

        List<int> choices = new List<int> { 0, 90, 180, 270 };

        int randomIndex = Random.Range(0, choices.Count);
        int randomChoice = choices[randomIndex];

        transform.Rotate(0f, 0f, randomChoice);
    }
    private void OnMouseDown()
    {

        // if (!ControllerScript.youWin)
        // {
            if (Input.GetMouseButton(0))
            {
                transform.Rotate(0f, 0f, 90f);
            }
        // }
    }
}