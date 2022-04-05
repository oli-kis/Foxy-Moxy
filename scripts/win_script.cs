using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class win_script : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D col)
    {
        SceneManager.LoadScene("win");
        ScoreTextScript.coinAmount = 0;
        LifeTextScript.lifeAmount = 3;
    }
}
