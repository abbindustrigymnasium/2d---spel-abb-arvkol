using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
    public void playGame(){
        SceneManager.LoadScene(1/*SceneManager.GetActiveScene().buildIndex+1*/);
    }
    public void playSecondGame(){
        SceneManager.LoadScene(3/*SceneManager.GetActiveScene().buildIndex+1*/);
    }
}
