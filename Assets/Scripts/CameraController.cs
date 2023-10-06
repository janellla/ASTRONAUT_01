using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;

    public Transform farBackground, cloud1, cloud2, cloud3, cloud4;
     public float minHeight, maxHeight;

     private float lastXPos;
    

    // Start is called before the first frame update
    void Start()
    {
        lastXPos = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, Mathf.Clamp(target.position.y, minHeight, maxHeight), transform.position.z);

        float amountToMoveX = transform.position.x - lastXPos;

        farBackground.position = farBackground.position + new Vector3(amountToMoveX, 0f, 0f);
        cloud1.position += new Vector3(amountToMoveX * 0.9f, 0f, 0f);
        cloud2.position += new Vector3(amountToMoveX * 0.8f, 0f, 0f);
        cloud3.position += new Vector3(amountToMoveX * 0.7f, 0f, 0f);
        cloud4.position += new Vector3(amountToMoveX * 0.6f, 0f, 0f);

        lastXPos = transform.position.x;


        
        
    }
}
