using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GooglePlayServicesScript : MonoBehaviour {

    static int hs;

    void Awake()
    {
        //PlayerPrefs.DeleteAll();
        DontDestroyOnLoad(transform.gameObject);
    }

    // Use this for initialization
    void Start()
    {
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;

        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();

        LogIn();


    }

    void Update()
    {
        hs = PlayerPrefs.GetInt("HighScore");
    }

    public void OnShowLeaderBoard()
    {

        if (Social.localUser.authenticated)
        {
            OnAddScoreToLeaderBorad(hs);
            Social.ShowLeaderboardUI();
        }

    }

    public static void OnAddScoreToLeaderBorad(int score)
    {
        if (Social.localUser.authenticated)
        {
            Social.ReportScore(score, HGPS.leaderboard_h_board, (bool success) =>
            {
                if (success)
                {
                    Debug.Log("Update Score Success");

                }
                else
                {
                    Debug.Log("Update Score Fail");
                }
            });
        } 
            
    }

    public void LogIn()
    {
        Social.localUser.Authenticate((bool success) =>
        {
            if (success)
            {
                Debug.Log("Login Sucess");
            }
            else
            {
                Debug.Log("Login failed");
            }
        });
    }
}
