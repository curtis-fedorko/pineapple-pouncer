using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class HardLevel : MonoBehaviour
{
private float speed = 2f;
public float timer = 1.5f; 

void Update()
{
    // Moves the object forward at two units per second.
    transform.Translate(Vector3.left * speed * Time.deltaTime);
    timer -= Time.deltaTime; 
    if(timer <= 0){
        SceneManager.LoadScene(ThrowObject.bi);
    }
}

void OnTriggerEnter(Collider other){

    if (other.CompareTag("rwall"))
    {

       transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    if (other.CompareTag("lwall"))
    {
       speed = 0; 
    }
    if (other.CompareTag("frontwall"))
    {
       speed = 0; 
    }
    if (other.CompareTag("backwall"))
    {
       speed = 0; 
    }
}
}
