using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplePrefab : MonoBehaviour
{
    public GameObject prefab;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < 100; i++)
        {
            Vector2 position = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
            Instantiate(prefab, position, Quaternion.identity);
        }
        //` Debug.Log(position);
    }
    // Update is called once per frame
    void Update()
    {

    }
}


