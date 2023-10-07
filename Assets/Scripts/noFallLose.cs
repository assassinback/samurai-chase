using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noFallLose : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 oldPos;
    public Vector3 newPos;
    void Start()
    {
        player = GameObject.Find("Player").transform;
        oldPos = player.position;
        newPos = player.position;
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
        float verticalVelocity = rb.velocity.y;
        if(verticalVelocity<=0)
        {

        }
        else
        {
            this.transform.position = new Vector3(this.transform.position.x, player.position.y - 4,this.transform.position.z);
        }
    }
}
