using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class Restart : MonoBehaviour
{
   public TextMeshProUGUI t;

   public AudioMixer mixer;

   public static int chosenLevel = 1;//global variable accesed from other scenes

     void Start() {
          if(Time.timeScale == 1){
               if(chosenLevel == 1)
                    t.text = "Game Over Nub, HighScore:" + PlayerPrefs.GetInt("normalHighScore").ToString();
               if(chosenLevel == 3)
                   t.text = "Game Over Nub, HighScore:" + PlayerPrefs.GetInt("melonHighScore").ToString();
          }
     }

   public void restart(){

     mixer.SetFloat("Volume", Mathf.Log10(PlayerPrefs.GetFloat("sliderVal"))*20);//update mixer volume

     //reset global variables to 0
     SpawnEnemeies.waveNum = 0;
     shootMelon.waveNum = 0;
     attack.score = 0;

     SceneManager.LoadScene(chosenLevel/*SceneManager.GetActiveScene().buildIndex-1*/);
   }
   public void MainMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene(0/*SceneManager.GetActiveScene().buildIndex-1*/);
        Debug.Log("wtf");
   }
}
