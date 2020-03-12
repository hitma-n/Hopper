using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    [SerializeField]
    float speed;
    Vector2 startPos;

    [SerializeField]
    float pos;

	// Use this for initialization
	void Start () {
        startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {


        if (!GameManager.isGameOver && GameManager.isStarted)
        {
            float newPos = Mathf.Repeat(Time.time * speed, pos);
            transform.position = startPos + Vector2.right * newPos;
        }

	}
}
