using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class damage_script : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        LifeTextScript.lifeAmount -= 1;

        if (LifeTextScript.lifeAmount < 1)
        {
            SceneManager.LoadScene("game_over");
            ScoreTextScript.coinAmount = 0;
            LifeTextScript.lifeAmount = 3;
        }
    }
}
