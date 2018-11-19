using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stickyscript : MonoBehaviour {

    Rigidbody2D rB;


    // Use this for initialization
    void Start () {
        rB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

    }
    void OnTriggerEnter2D(Collider2D col)
    {
        rB.constraints = RigidbodyConstraints2D.FreezePosition;
    }
}
