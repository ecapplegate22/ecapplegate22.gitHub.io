using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WASD : MonoBehaviour
{

    public float moveSpeed = 5f;
    //public float turnSpeed = 5f;
    // Use this for initialization
    // Use this for initialization

    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
            Debug.Log("a key pressed");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);
            Debug.Log("d key pressed");

            if (Input.GetKey("space"))
            {
                if (Input.GetKeyDown("space"))
                {
                    transform.Translate(Vector2.up * Time.deltaTime * moveSpeed);
                }
            }
        }
    }
}
