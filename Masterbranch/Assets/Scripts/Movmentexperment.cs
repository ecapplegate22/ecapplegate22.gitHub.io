using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movmentexperment : MonoBehaviour {
    Vector2 m_NewForce;
    Rigidbody2D m_Rigidbody;
    // Use this for initialization
    void Start () {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        m_NewForce = new Vector2(0.0f, 10.0f);
       
    }

    // Update is called once per frame
    void Update () {
        bool left = Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.D);
        if(left){
            transform.Translate(Vector2.left*Time.deltaTime);
        }
        if(right){
            transform.Translate(Vector2.right * Time.deltaTime);
        }
        if(Input.GetKeyDown("space")){
            m_Rigidbody.AddForce(m_NewForce, ForceMode2D.Impulse);
        }
           
        }

}