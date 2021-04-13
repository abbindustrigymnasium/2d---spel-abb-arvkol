using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   public static int chosenLevel = 1;//global variable accesed from other scenes
   public void restart(){
        SceneManager.LoadScene(chosenLevel/*SceneManager.GetActiveScene().buildIndex-1*/);
   }
   public void MainMenu(){
        SceneManager.LoadScene(0/*SceneManager.GetActiveScene().buildIndex-1*/);
   }
}
