using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    //global variables are reset so if the player returns to the main menu the starting scores will be 0 etc.
    public void playGame(){//starts the normal mode scene
        shootMelon.waveNum = 0;
        SpawnEnemeies.waveNum = 0;
        attack.score = 0;
        SceneManager.LoadScene(1/*SceneManager.GetActiveScene().buildIndex+1*/);
        attack.score = 0;
    }
    public void playSecondGame(){//starts practice mode scene
        shootMelon.waveNum = 0;
        attack.score = 0;
        SpawnEnemeies.waveNum = 0;
        SceneManager.LoadScene(3/*SceneManager.GetActiveScene().buildIndex+1*/);
    }
    public void doExitGame() {//quits game
        Application.Quit();
    }
}
