using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class levelLoader : MonoBehaviour
{
    public Slider slider;
    public Text myText;
    public void loadLevel()
    {
        
    }

    IEnumerator loadAsync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync("PlayNow Screen");
        while(!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            myText.text = progress * 100f + "%";
            yield return new WaitForSeconds(0.3f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadAsync());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
