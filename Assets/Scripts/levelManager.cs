using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class levelManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    void Start()
    {
        if(!PlayerPrefs.HasKey("currentLevel"))
        {
            PlayerPrefs.SetInt("currentLevel", 1);
        }
        text.text = "Level:"+PlayerPrefs.GetInt("currentLevel") + "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
