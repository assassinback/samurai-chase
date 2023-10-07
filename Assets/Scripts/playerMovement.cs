using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float speed = 3;
    public float jump = 10;
    public Transform myTransform;
    public Rigidbody2D myRigidbody2d;
    public bool isGrounded = false;
    public Transform tagGround;
    public LayerMask mask;
    public float hinput = 0;
    AnimationController myAnim;
    public int extraJumps=1;
    void Start()
    {
        myAnim = this.gameObject.GetComponent<AnimationController>();
        myTransform = this.transform;
        myRigidbody2d = this.GetComponent<Rigidbody2D>();
        //Debug.Log("here");
    }
    
    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.Linecast(myTransform.position, tagGround.position, mask);
        if (!isGrounded)
        {
            this.GetComponent<CapsuleCollider2D>().size = new Vector2(2.5f, 3.22f);
        }
        else
        {
            extraJumps = 1;
            this.GetComponent<CapsuleCollider2D>().size = new Vector2(2.5f, 4.37f);
        }
        //if (transform.localScale.x<0)
        //{
        //    tagGround.position = new Vector3(myTransform.position.x + 0.2f, tagGround.position.y, tagGround.position.z);
        //}
        //else if(transform.localScale.x > 0)
        //{
        //    tagGround.position = new Vector3(myTransform.position.x - 0.2f, tagGround.position.y, tagGround.position.z);
        //}
        //else
        //{
        //    tagGround.position = new Vector3(myTransform.position.x, tagGround.position.y, tagGround.position.z);
        //}

        //isGrounded = Physics2D.OverlapArea(myTransform.position, myTransform.position, mask);
        if (extraJumps == 0)
        {
            myAnim.updateDoubleJump(true);
            //Debug.Log("here");

        }
        else {
            
            myAnim.updateJump(isGrounded);
        }
        
        //Move(Input.GetAxisRaw("Horizontal"));
        //if(Input.GetButtonDown("Jump"))
        //{
        //    Jump();
        //}    
        //Debug.Log("here");
        Move(hinput);
    }
    public void Move(float horizontal)
    {
        Vector2 mySpeed = myRigidbody2d.velocity;
        mySpeed.x = horizontal * speed;
        myRigidbody2d.velocity = mySpeed;
        //Debug.Log(myRigidbody2d.velocity);
    }
    public void Jump()
    {
        if(extraJumps <= 0)
        {
            return;
        }
        if (extraJumps>0)
        {
            myRigidbody2d.velocity = jump * Vector2.up;
            extraJumps--;
            
        }
    }
    public void startMoving(float horizontal)
    {
        hinput = horizontal;
        myAnim.UpdateSpeed(hinput);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name== "Win" || col.gameObject.name== "Win(Clone)" || col.gameObject.name == "WinOpposite(Clone)")
        {
            PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("currentLevel")+1);
            GameObject obj=GameObject.Find("AdManager");
            //Debug.Log(obj);
            obj.GetComponent<AdManager>().showVideo();
            this.gameObject.GetComponent<openScene>().loadScene("Victory Screen");
        }
        if (col.gameObject.name == "Coin" || col.gameObject.name== "Coin(Clone)")
        {
            PlayerPrefs.SetInt("currentCoins", PlayerPrefs.GetInt("currentCoins") + 1);
            Destroy(col.gameObject);
        }
        if(col.gameObject.name=="lose")
        {
            GameObject obj = GameObject.Find("AdManager");
            //Debug.Log(obj);
            obj.GetComponent<AdManager>().showVideo();
            this.gameObject.GetComponent<openScene>().loadScene("GameOver Scene");
        }
    }
}
