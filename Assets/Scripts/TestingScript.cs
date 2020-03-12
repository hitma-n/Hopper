using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingScript : MonoBehaviour {


    [SerializeField]
    bool sky;

    public float speed = 0.1f;
    private Vector2 offset = Vector2.zero;
    private Material mat;


	// Use this for initialization
	void Start () {

        mat = GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainTex");
        if(!sky)
          GetComponent<Renderer>().sortingLayerName = "Ground"; 
	}
	
	// Update is called once per frame
	void Update () {
        offset.x += speed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex",offset);
	}
}
