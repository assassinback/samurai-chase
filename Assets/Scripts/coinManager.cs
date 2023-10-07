using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class coinManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text text;
    void Start()
    {
        if (!PlayerPrefs.HasKey("currentCoins"))
        {
            PlayerPrefs.SetInt("currentCoins", 0);
        }
        text.text = PlayerPrefs.GetInt("currentCoins")+"";
    }

    // Update is called once per frame
    void Update()
    {
        text.text = PlayerPrefs.GetInt("currentCoins") + "";
    }
}
