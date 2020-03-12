using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerUpperColBlocker : MonoBehaviour {

    int randomForAds;

    void OnCollisionEnter2D(Collision2D col)
    {
        //Debug.Log("Player entered");

        if (col.gameObject.tag == "Player" && !GameManager.isGameOver)
        {
            randomForAds = PlayerPrefs.GetInt("checkForAds");
            PlayerPrefs.SetInt("checkForAds", ++randomForAds);

            PlayerMovement.dieSound = true;
            GameManager.isGameOver = true;
        }
    }
}
