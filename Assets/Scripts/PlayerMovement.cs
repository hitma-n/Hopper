using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    Rigidbody2D player;

    [SerializeField]
    float upForce;

    [SerializeField]
    AudioSource _audio;

    [SerializeField]
    AudioSource _audio2;

    [SerializeField]
    AudioSource _audio3;

    public static bool playSound;
    public static bool dieSound;

	// Use this for initialization
	void Start () {
        playSound = false;
        dieSound = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0) && GameManager.isStarted && !GameManager.isGameOver)
        {
            player.velocity = Vector2.zero;
            player.AddForce(new Vector2(0, upForce));
            _audio.Play();
        }

        if (playSound)
        {
            _audio2.Play();
            playSound = false;
        }

        if (dieSound)
        {
            _audio3.Play();
            dieSound = false;
        }

	}


    
}
