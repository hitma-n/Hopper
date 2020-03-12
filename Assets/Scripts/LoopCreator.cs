using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopCreator : MonoBehaviour {

    [SerializeField]
    GameObject objectPrefab;

    [SerializeField]
    GameObject tempObjs;

    [SerializeField]
    float time;

    [SerializeField]
    float repeatRate;

    [SerializeField]
    Transform cameraPos;

    public static Stack stack1;
    GameObject temp,temp1;

    float maxYPos = 2.25f;

    Camera cam;
    float height;
    float width;

    // Use this for initialization
    void Start () {

        stack1 = new Stack();

        //For camera
        cam = Camera.main;
        height = 2f * cam.orthographicSize;
        width = height * cam.aspect;

        //Pushing in objectStack
        for (int i = 0; i < 10; i++)
        {
            temp = Instantiate(objectPrefab);
            temp.transform.SetParent(tempObjs.transform);
            temp.SetActive(false);
            stack1.Push(temp);
        }


        transform.position = new Vector3(cameraPos.position.x + width/2 + 0.5f,0,transform.position.z);

        SpwanLoops();

    }
	
	// Update is called once per frame
	void Update () {
		


	}

    void SpwanLoops()
    {
        InvokeRepeating("SpwanLoop", time, repeatRate);
    }

    void SpwanLoop()
    {
        /*temp = (GameObject) stack1.Pop();
        temp.transform.GetChild(0).position = new Vector3(transform.position.x, transform.position.y, 0);
        temp.transform.GetChild(1).position = new Vector3(transform.position.x,Random.Range(-maxYPos,maxYPos),0);
        temp.SetActive(true);*/
        if (!GameManager.isGameOver && GameManager.isStarted)
        {
            temp = (GameObject)Instantiate(objectPrefab);
            temp.transform.SetParent(tempObjs.transform);
            temp.transform.GetChild(0).position = new Vector3(transform.position.x, transform.position.y, 0);
            temp.transform.GetChild(1).position = new Vector3(transform.position.x, Random.Range(-maxYPos, maxYPos), 0);
        }

    }
}
