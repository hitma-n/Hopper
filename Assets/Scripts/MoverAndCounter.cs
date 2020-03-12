using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoverAndCounter : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col) {

        if (col.gameObject.tag == "Player")
        {

            LoopBehaviour.counter += 1;
            transform.gameObject.SetActive(false);

            if (LoopBehaviour.counter == 3)
            {
                
                transform.parent.parent.GetChild(0).GetComponent<BlockerBehaviour>().MoverBlocker = true;
                
                //BlockerBehaviour.MoverBlocker = true;
                GameManager.score += 1;
                PlayerMovement.playSound = true;

            }

        }

    }
}
