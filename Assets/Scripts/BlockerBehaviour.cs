using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockerBehaviour : MonoBehaviour {


    [SerializeField]
    GameObject lowerPart;

    [SerializeField]
    GameObject upperPart;

    public bool MoverBlocker;

    float moverLowerTo, moveUpperTo,movingSpeed;

	// Use this for initialization
	void Start () {
        moverLowerTo = -5.96f;
        moveUpperTo = 7.07f;
        movingSpeed = 0.5f;
        MoverBlocker = false;
    }
	
	// Update is called once per frame
	void Update () {

	}

    void FixedUpdate()
    {
        if (MoverBlocker)
        {
            lowerPart.transform.position = Vector3.Lerp(lowerPart.transform.position,
                                          new Vector3(lowerPart.transform.position.x, moverLowerTo, 0), movingSpeed);
            upperPart.transform.position = Vector3.Lerp(upperPart.transform.position,
                                          new Vector3(upperPart.transform.position.x, moveUpperTo, 0), movingSpeed);
        }
    }

    

}
