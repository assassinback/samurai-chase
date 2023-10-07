using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWall : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform myTrans;
    void Start()
    {
        myTrans = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.x>2.4f)
        {
            this.transform.position = new Vector3(2.4f,this.transform.position.y,this.transform.position.z);
        }
        else if(this.transform.position.x<-2.4f)
        {
            this.transform.position = new Vector3(-2.4f, this.transform.position.y, this.transform.position.z);
        }    
    }
}
