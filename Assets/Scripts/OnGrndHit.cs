using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGrndHit : MonoBehaviour {


    [SerializeField]
    AudioSource _audio;

    void OnCollisionEnter2D(Collision2D col)
    {
        _audio.Play();
    }
}
