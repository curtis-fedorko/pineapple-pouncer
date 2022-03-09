using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 

    }
    public void PlayOne(){
        SceneManager.LoadScene("Scene1"); 

    }
    public void PlayTwo(){
        SceneManager.LoadScene("Scene2"); 

    }
    public void PlayThree(){
        SceneManager.LoadScene("Scene3"); 

    }
    public void PlayFour(){
        SceneManager.LoadScene("Scene4"); 

    }
    public void PlayFive(){
        SceneManager.LoadScene("Scene5"); 

    }
    
    public void PlaySix(){
        SceneManager.LoadScene("Scene6"); 

    }
    public void PlaySeven(){
        SceneManager.LoadScene("Scene7"); 

    }
    public void PlayEight(){
        SceneManager.LoadScene("Scene8"); 

    }
    public void PlayNine(){
        SceneManager.LoadScene("Scene9"); 

    }
    public void PlayTen(){
        SceneManager.LoadScene("Scene10"); 

    }
    public void PlayEleven(){
        SceneManager.LoadScene("Scene11"); 

    }
    public void PlayTwelve(){
        SceneManager.LoadScene("Scene12"); 

    }
    public void PlayThirteen(){
        SceneManager.LoadScene("Scene13"); 

    }
        public void Levels(){
        SceneManager.LoadScene("Levels"); 

    }
    public void Home(){
        SceneManager.LoadScene("StartGame"); 

    }
    public void Options(){
        SceneManager.LoadScene("Options"); 

    }
    public void PlayCurr(){
        SceneManager.LoadScene(ThrowObject.bi); 

    }
    public void Pause(){
        SceneManager.LoadScene("Pause"); 

    }



    
   
}
