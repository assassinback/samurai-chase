using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveWithCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 oldPos;
    public Vector3 newPos;
    public Transform myTrans;
    public Transform camerapos;
    void Start()
    {
        myTrans = this.transform;
        camerapos = GameObject.FindGameObjectWithTag("MainCamera").transform;
        player = GameObject.Find("Player").transform;
        oldPos = player.position;
        newPos = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        float verticalVelocity = rb.velocity.y;
        if (verticalVelocity <= 0)
        {

        }
        else
        {
            if(camerapos.position.y < myTrans.position.y)
            {
                camerapos.transform.position = new Vector3(camerapos.transform.position.x, myTrans.position.y, camerapos.transform.position.z);
            }
            
        }
        //if (myTrans.position.y>0)
        //{
            //camerapos.transform.position = new Vector3(camerapos.transform.position.x,myTrans.position.y,camerapos.transform.position.z);
        //}

    }
}
