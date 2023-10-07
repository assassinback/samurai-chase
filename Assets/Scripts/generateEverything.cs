using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateEverything : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    void Start()
    {
        int num=0;
        int num1= Random.Range(15, 25);
        float xrange=0;
        float yrange=0;
        int genCoin = 0;
        for (int i=0;i<num1;i++)
        {
            num = Random.Range(1, 4);
            if(xrange<0)
            {
                xrange = Random.Range(1, 2.4f);
            }
            else if (xrange > 0)
            {
                xrange = Random.Range(-2.4f, -1);
            }
            else 
            {
                xrange = Random.Range(-2.4f, 2.4f);
            }
            
            yrange = 2.36f;
            if(PlayerPrefs.GetString("backgroundTime")== "afternoon")
            {
                //yrange = 2.3f;
            }
            else if (PlayerPrefs.GetString("backgroundTime") == "Night")
            {
                //yrange = Random.Range(2.4f, 2.6f);
            }
            Instantiate(Resources.Load(PlayerPrefs.GetString("backgroundTime") +"/"+num) as GameObject,new Vector3(xrange,this.transform.position.y+yrange+ this.transform.position.z),new Quaternion());
            genCoin = Random.Range(0, 3);
            //Debug.Log(genCoin);
            if(genCoin==2)
            {
                Instantiate(Resources.Load("Coin") as GameObject, new Vector3(xrange, this.transform.position.y + yrange+1.5f + this.transform.position.z), new Quaternion());
            }
            this.transform.position = new Vector3(xrange, this.transform.position.y + yrange + this.transform.position.z);
            //Debug.Log(this.transform.position.x);

        }
        if (xrange < 0)
        {
            Instantiate(Resources.Load("Win") as GameObject, new Vector3(2.4f, this.transform.position.y + yrange + this.transform.position.z), new Quaternion());
        }
        else if (xrange > 0)
        {
            Instantiate((Resources.Load("WinOpposite") as GameObject), new Vector3(-2.4f, this.transform.position.y + yrange + this.transform.position.z), new Quaternion());
        }
        else
        {
            Instantiate(Resources.Load("levelEnd") as GameObject, new Vector3(2.4f, this.transform.position.y + yrange + this.transform.position.z), new Quaternion());

        }
        Instantiate(Resources.Load("lights") as GameObject, new Vector3(2.4f, this.transform.position.y + yrange + this.transform.position.z), new Quaternion());
    }
}
