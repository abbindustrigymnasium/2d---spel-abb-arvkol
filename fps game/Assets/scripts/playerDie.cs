using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDie : MonoBehaviour
{
    // public GameObject s;

    //if the player collids with enemie he dies
    private void OnTriggerEnter(Collider other) {
         if (other.CompareTag("Enemy")) { 
             // Restart r = s.GetComponent<Restart>();

             //gets which gameMode was played and changes variables to display highScore accordingly
             Restart.chosenLevel = SceneManager.GetActiveScene().buildIndex;
             if(Restart.chosenLevel == 1){
                 if(attack.score > PlayerPrefs.GetInt("normalHighScore")){
                     PlayerPrefs.SetInt("normalHighScore", attack.score);
                 }
             }
             else if(Restart.chosenLevel == 3){
                 if(shootMelon.waveNum > PlayerPrefs.GetInt("melonHighScore")){
                     PlayerPrefs.SetInt("melonHighScore", shootMelon.waveNum);
                 }
             }
             Debug.Log("ur dead");
             Cursor.lockState = CursorLockMode.None;
             SceneManager.LoadScene(2/*SceneManager.GetActiveScene().buildIndex+1*/);
        }
      
    }
}
