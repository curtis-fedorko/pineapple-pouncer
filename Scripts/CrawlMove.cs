using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class CrawlMove : MonoBehaviour
{
public float speed = 2f;
public static bool isHit; 
public int tracky; 
void Start(){
    isHit = false; 
    tracky = 0; 
}
void Update()
{
    // Moves the object forward at two units per second.
    if(tracky == 0){
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    if(tracky == 1){
    transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    if(tracky == 2){
    transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
    if(tracky == 3){
    transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    if(tracky == 4){
    transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
void OnTriggerEnter(Collider other){
    if (other.CompareTag("wall"))
    {
       speed = speed * -1;
    }
    else if (other.CompareTag("lwall"))
    {
        tracky = 1; 
    }
    else if (other.CompareTag("rwall"))
    {
       tracky = 2; 
    }
    else if (other.CompareTag("frontwall"))
    {
       tracky = 3; 
    }
    else if (other.CompareTag("backwall"))
    {
       tracky = 4; 
    }
    else if(other.CompareTag("pineapple")){
        Debug.Log("line 41"); 
        isHit = true; 
        } 
    }

}

