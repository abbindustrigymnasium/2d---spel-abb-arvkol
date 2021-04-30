using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{

    public GameObject returnButton;
    private void Update() {
        //checking if the player is pausing the game
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(Time.timeScale == 0){
                Time.timeScale = 1;
                returnButton.SetActive(false);
                 Cursor.lockState = CursorLockMode.Locked;
                //Time.fixedDeltaTime = 1;
            }
            else{
                Time.timeScale = 0;
                returnButton.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                //Time.fixedDeltaTime = 0;
            }
        }
    }

    public void MainMenu(){
        Time.timeScale = 1;
        SceneManager.LoadScene(0/*SceneManager.GetActiveScene().buildIndex-1*/);
        Debug.Log("wtf");
   }
}
