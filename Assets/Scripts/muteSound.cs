using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class muteSound : MonoBehaviour
{
    public Sprite sound;
    public Sprite mute;
    public void Start()
    {
        if (GameObject.Find("menuSound").GetComponent<AudioSource>().mute)
        {
            this.gameObject.GetComponent<Image>().sprite = mute;
        }
        else
        {
            this.gameObject.GetComponent<Image>().sprite = sound;

        }
    }
    public void muting()
    {
        GameObject.Find("menuSound").GetComponent<AudioSource>().mute = !GameObject.Find("menuSound").GetComponent<AudioSource>().mute;
        GameObject.Find("levelSound").GetComponent<AudioSource>().mute = !GameObject.Find("levelSound").GetComponent<AudioSource>().mute;
        if(GameObject.Find("menuSound").GetComponent<AudioSource>().mute)
        {
            this.gameObject.GetComponent<Image>().sprite = mute;
        }
        else
        {
            this.gameObject.GetComponent<Image>().sprite = sound;
            
        }
    }
}
