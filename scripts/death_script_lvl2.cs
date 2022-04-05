using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class death_script_lvl2 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        LifeTextScript.lifeAmount -= 3;

        if (LifeTextScript.lifeAmount < 1)
        {
            SceneManager.LoadScene("game_over_lvl2");
            ScoreTextScript.coinAmount = 0;
            LifeTextScript.lifeAmount = 3;
        }
    }
}
