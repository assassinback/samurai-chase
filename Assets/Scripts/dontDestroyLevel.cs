using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyLevel : MonoBehaviour
{
    private static dontDestroyLevel playerInstance;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
