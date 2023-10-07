using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pauseScript : MonoBehaviour
{
    public GameObject pause;
    public GameObject play;
    public void pauseGame()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
        play.SetActive(false);
    }
    public void playGame()
    {
        Time.timeScale = 1;
        pause.SetActive(false);
        play.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
