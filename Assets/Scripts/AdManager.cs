using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;


public class AdManager : MonoBehaviour, IUnityAdsListener
{
    // Start is called before the first frame update
    private string googleId = "3846099";
    private string appleId = "3846098";
    private string normalAd = "video";
    private string rewardedAd = "rewardedVideo";
    private bool isTargetPlayStore;
    private bool isTestAd=true;
    //private AudioSource source;
    private AdManager point;
    void Start()
    {
        Advertisement.Initialize(googleId, isTestAd);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showVideo()
    {
        if (PlayerPrefs.HasKey("showAd") && !PlayerPrefs.HasKey("noads"))
        {
            PlayerPrefs.SetInt("showAd", PlayerPrefs.GetInt("showAd")+1);
            if (PlayerPrefs.GetInt("showAd") > 1)
            {
                if (Advertisement.IsReady())
                {
                    Advertisement.Show();
                    PlayerPrefs.SetInt("showAd", 0);
                }
            }
        }
        else
        {
            PlayerPrefs.SetInt("showAd", 0);
            if (Advertisement.IsReady() && !PlayerPrefs.HasKey("noads"))
            {
                Advertisement.Show();
                PlayerPrefs.SetInt("showAd", 0);
            }
        }
    }
    public void ShowRewardedVideo()
    {
        if (Advertisement.IsReady(rewardedAd))
        {
            Advertisement.Show(rewardedAd);
        }
        // Check if UnityAds ready before calling Show method:

    }

    // Implement IUnityAdsListener interface methods:
    public void OnUnityAdsDidFinish(string surfacingId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            //Debug.Log("here");
            if(surfacingId == rewardedAd)
            {
                PlayerPrefs.SetInt("currentCoins", PlayerPrefs.GetInt("currentCoins")+100);
            }
            // Reward the user for watching the ad to completion.
        }
        else if (showResult == ShowResult.Skipped)
        {
            // Do not reward the user for skipping the ad.
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string surfacingId)
    {
        // If the ready Ad Unit or legacy Placement is rewarded, show the ad:
        
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string surfacingId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }

    // When the object that subscribes to ad events is destroyed, remove the listener:
    public void OnDestroy()
    {
        Advertisement.RemoveListener(this);
    }
}
