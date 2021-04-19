using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Restart : MonoBehaviour
{
   public TextMeshProUGUI t;

   public static int chosenLevel = 1;//global variable accesed from other scenes

     void Start() {
          if(chosenLevel == 1)
               t.text = "Game Over Nub, HighScore:" + PlayerPrefs.GetInt("normalHighScore").ToString();
          if(chosenLevel == 3)
               t.text = "Game Over Nub, HighScore:" + PlayerPrefs.GetInt("melonHighScore").ToString();
     }

   public void restart(){
      
     SpawnEnemeies.waveNum = 0;
     shootMelon.waveNum = 0;

     SceneManager.LoadScene(chosenLevel/*SceneManager.GetActiveScene().buildIndex-1*/);
   }
   public void MainMenu(){
        SceneManager.LoadScene(0/*SceneManager.GetActiveScene().buildIndex-1*/);
   }
}
