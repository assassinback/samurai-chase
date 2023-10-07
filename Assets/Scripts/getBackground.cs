using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getBackground : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if(!PlayerPrefs.HasKey("backgroundTime"))
        {
            PlayerPrefs.SetString("backgroundTime","dawn");
        }
        if(PlayerPrefs.GetInt("currentLevel") % 5==1)
        {
            this.GetComponent<SpriteRenderer>().sprite=Resources.LoadAll<Sprite>("dawn")[0];
            PlayerPrefs.SetString("backgroundTime", "dawn");
        }
        else if (PlayerPrefs.GetInt("currentLevel") % 5 == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("evening")[0];
            PlayerPrefs.SetString("backgroundTime", "evening");
        }
        else if (PlayerPrefs.GetInt("currentLevel") % 5 == 3)
        {
            this.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("afternoon")[0];
            PlayerPrefs.SetString("backgroundTime", "afternoon");
        }
        else if (PlayerPrefs.GetInt("currentLevel") % 5 == 4)
        {
            this.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("sunset")[0];
            PlayerPrefs.SetString("backgroundTime", "sunset");
        }
        else if (PlayerPrefs.GetInt("currentLevel") % 5 == 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = Resources.LoadAll<Sprite>("Night")[0];
            PlayerPrefs.SetString("backgroundTime", "Night");
        }
    }
}
