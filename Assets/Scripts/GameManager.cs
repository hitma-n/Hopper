using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    [SerializeField]
    Text scoreText;

    [SerializeField]
    GameObject tap;

    [SerializeField]
    Rigidbody2D player;

    [SerializeField]
    GameObject twitterBut;

    [SerializeField]
    GameObject facebookBut;

    [SerializeField]
    GameObject scoreTextObj;

    [SerializeField]
    float upForce;

    [SerializeField]
    GameObject gameOverPanel;

    [SerializeField]
    GameObject GameOverText;

    [SerializeField]
    Text highScoreTextPanel;

    [SerializeField]
    Text scoreTextPanel;

    [SerializeField]
    Animator anim;

    [SerializeField]
    GameObject[] frontIbjs;

    [SerializeField]
    GameObject[] titleObj;

    public static int score;
    public static bool isGameOver;
    public static bool isStarted;

    int prevHighScore;

	// Use this for initialization
	void Start () {

        isGameOver = false;
        isStarted = false;
        prevHighScore = PlayerPrefs.GetInt("HighScore");
        score = 0;

    }
	
	// Update is called once per frame
	void Update () {

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 mousePos2D = new Vector2(mousePos.x,mousePos.y);
        Vector3 dir = Vector3.zero;

       

        if(!isGameOver && isStarted)
            scoreText.text = score.ToString();

        if (Input.GetMouseButtonDown(0) && !isStarted)
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, dir);

            if (hit.transform != null)
            {
                if (hit.transform.tag == "Gotobuttons")
                {
                    //Do Nothing
                }
                else if(hit.transform.tag == "PlayGame")
                {
                    isStarted = true;
                    anim.Play("GoOnPlay");

                    for(int i=0;i<titleObj.Length;i++)
                        titleObj[i].SetActive(false);

                    player.bodyType = RigidbodyType2D.Dynamic;
                    player.velocity = Vector2.zero;
                    player.AddForce(new Vector2(0, upForce));
                    scoreTextObj.SetActive(true);
                    StartCoroutine(deactive());
                }
            }
            
        }


        if (isGameOver)
        {
            gameOverPanel.SetActive(true);
            scoreTextObj.SetActive(false);
            scoreTextPanel.text = score.ToString();
            GameOverText.SetActive(true);

            if (prevHighScore < score)
            {
                PlayerPrefs.SetInt("HighScore", score);
                highScoreTextPanel.text = score.ToString();
                GooglePlayServicesScript.OnAddScoreToLeaderBorad(score);
            }
            else {
                highScoreTextPanel.text = prevHighScore.ToString();
            }
        }
        

    }


    IEnumerator deactive()
    {
        yield return new WaitForSeconds(0f);
        for(int i = 0; i < frontIbjs.Length;i++)
            frontIbjs[i].SetActive(false);
    }

}


