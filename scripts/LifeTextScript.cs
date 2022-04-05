using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeTextScript : MonoBehaviour
{
    Text text;
    public static int lifeAmount = 3;

    void Start ()
    {
        text = GetComponent<Text> ();
    }

void Update()
{
    text.text = "Hearts: " + lifeAmount.ToString();
}
}
