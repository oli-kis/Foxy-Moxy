using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
 
    public void StartGame()
    {
        LifeTextScript.lifeAmount = 3;
        ScoreTextScript.coinAmount = 0;
        SceneManager.LoadScene("start_menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartMenu(){
        SceneManager.LoadScene("start_menu");
    }

     public void Level2(){
        SceneManager.LoadScene("level_2");
    }

    public void Level1(){
        SceneManager.LoadScene("demo");
    }
}
