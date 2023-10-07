using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class manageSounds : MonoBehaviour
{
    public AudioSource menuSound;
    public AudioSource levelSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name== "levelGenerator" || SceneManager.GetActiveScene().name == "Start Level")
        {
            if (!levelSound.isPlaying)
            {
                levelSound.Play();
                menuSound.Stop();
            }
        }
        else
        {
            if (!menuSound.isPlaying)
            {
                menuSound.Play();
                levelSound.Stop();
            }
        }
    }
}
