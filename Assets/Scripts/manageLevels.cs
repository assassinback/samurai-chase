using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageLevels : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("currentLevel", 1);
        if (!PlayerPrefs.HasKey("currentLevel"))
        {
            PlayerPrefs.SetInt("currentLevel", 1);
        }
    }
    public void makeLevel()
    {
        if (PlayerPrefs.GetInt("currentLevel") == 1)
        {
            this.gameObject.GetComponent<openScene>().loadScene("Start Level");
        }
        else
        {
            this.gameObject.GetComponent<openScene>().loadScene("levelGenerator");
            //PlayerPrefs.SetInt("currentLevel", PlayerPrefs.GetInt("currentLevel")+1);
        }
    }
}
