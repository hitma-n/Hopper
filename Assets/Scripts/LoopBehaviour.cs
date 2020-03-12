using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopBehaviour : MonoBehaviour {

    [SerializeField]
    float speedX;

    public static int counter;

	// Use this for initialization
	void Start () {
        counter = 0;
	}
	
	// Update is called once per frame
	void Update () {

        if(!GameManager.isGameOver)
            transform.position = new Vector3(transform.position.x + speedX, transform.position.y,0);

        

	}
}
