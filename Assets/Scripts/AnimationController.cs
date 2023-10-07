using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public static AnimationController anim;
    public Transform myTransform;
    public Animator myAnim;
    public Vector3 flip;
    // Start is called before the first frame update
    void Start()
    {
        anim = this; 
        myTransform = this.transform;
        myAnim = this.gameObject.GetComponent<Animator>();
        flip = myTransform.localScale;
    }
    public void flipart(float speed)
    {
        //Debug.Log("Speed:"+speed);
        //Debug.Log("Flip:" + flip.x);
        if ((speed<0 && flip.x>= 0.304085f) ||(speed>0 && flip.x<=-0.304085f))
        {
            
            flip.x *= -1;
            myTransform.localScale = flip;
        }
    }
    // Update is called once per frame
    public void UpdateSpeed(float speed)
    {
        myAnim.SetFloat("speed", speed);
        flipart(speed);
    }
    public void updateJump(bool jump)
    {
        //myAnim = myTransform.gameObject.GetComponent<Animator>();
        //Debug.Log(myAnim);
        myAnim.SetBool("isGrounded", jump);
        if(!jump)
        {
            updateDoubleJump(false);
        }
    }
    public void updateDoubleJump(bool animValue)
    {
        //myAnim = myTransform.gameObject.GetComponent<Animator>();
        //Debug.Log(myAnim);
        myAnim.SetBool("doubleJump", animValue);
    }
}
