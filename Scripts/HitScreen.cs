using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class HitScreen : MonoBehaviour
{
public float time = 1.5f; 
void Update()
{
    time -= Time.deltaTime; 
    if(time <= 0){
        SceneManager.LoadScene(ThrowObject.bi + 1);
    }
}
}
