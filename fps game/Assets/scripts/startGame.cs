using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public void playGame(){
        shootMelon.waveNum = 0;
        SpawnEnemeies.waveNum = 0;
        attack.score = 0;
        SceneManager.LoadScene(1/*SceneManager.GetActiveScene().buildIndex+1*/);
        attack.score = 0;
    }
    public void playSecondGame(){
        shootMelon.waveNum = 0;
        attack.score = 0;
        SpawnEnemeies.waveNum = 0;
        SceneManager.LoadScene(3/*SceneManager.GetActiveScene().buildIndex+1*/);
    }
    public void doExitGame() {
        Application.Quit();
    }
}
