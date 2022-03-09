using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PineMove : MonoBehaviour
{
    float speed = 7.5f; 

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
}
