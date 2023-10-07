using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class openScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
    public void loadSceneID(int sceneid)
    {
        SceneManager.LoadScene(sceneid);
    }
}
