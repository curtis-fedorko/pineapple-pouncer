using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrawlMoveBack : MonoBehaviour
{
   
    float speed = 7f; 
    float rotationsPerMinute = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        transform.Rotate(180f*rotationsPerMinute*Time.deltaTime,0,0);
    }
}
