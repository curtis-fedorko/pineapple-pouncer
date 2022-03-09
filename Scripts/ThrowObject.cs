using System.Collections;
using System; 
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
public class ThrowObject : MonoBehaviour
{
    float speed = 75f; 
    public static string sce; 
    public static int bi; 
    public static int clicks; 
    public float time; 
    
    void Start(){
    clicks = 0; 
    sce = SceneManager.GetActiveScene().name;  
    bi = SceneManager.GetActiveScene().buildIndex; 
    } 
    IEnumerator KillPlayer(){ //creating a function
       yield return new WaitForSeconds(.08f); //tell unity to wait!!
          if(CrawlMove.isHit){
           SceneManager.LoadScene("HitScreen");
         }
         else{
           SceneManager.LoadScene("HardLevel");
       }
    }

void Update()
{
    time += Time.deltaTime;
    // time class for slowing down once click 
    if(Input.GetKeyDown(KeyCode.Space) /*|| Input.GetMouseButton(0)*/){
         transform.Translate(Vector3.back * speed * Time.deltaTime);
         StartCoroutine(KillPlayer()); 
     
    }
    if(time >= 10){
         SceneManager.LoadScene("HardLevel");
           }

    if(Input.GetKeyDown(KeyCode.DownArrow)){
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
    }
}

}
