using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour {

    int times;

    void Start()
    {
        times = PlayerPrefs.GetInt("NoOfTimes");
    }

    public void goToHome()
    {
        PlayerPrefs.SetInt("NoOfTimes",++times);
        SceneManager.LoadScene(0);
    }

    public void gotoFacebook()
    {
        Application.OpenURL("https://www.facebook.com/pineappgamess/");
    }

    public void gotoTwitter()
    {
        Application.OpenURL("https://twitter.com/pineappgamess");
    }

    public void gotoInsta()
    {
        Application.OpenURL("https://www.instagram.com/pineappgamess");
    }


}
