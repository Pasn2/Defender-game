using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class AdManager : MonoBehaviour,IUnityAdsListener
{
    public static AdManager instance;

    #if UNITY_IOS
    string gameid = "5149290";
    string platformName = "iOS"
    #else
    string gameid = "5149291";
    string platformName = "Android";
    #endif
    private void Awake()
    {
        if (instance != null && instance != this) 
        { 
            Destroy(this); 
        } 
        else{
            instance = this;
        }
    }
    void Start()
    {
        Advertisement.Initialize(gameid);
    }
    public void PlayRevardedAd()
    {
        if(Advertisement.IsReady("Rewarded_" + platformName))
        {
            Advertisement.Show("Rewarded_" + platformName);
        }
        else
        {
            Debug.Log("Rewarded ad is not ready");
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        print("ADS ARE READY");
    }

    public void OnUnityAdsDidError(string message)
    {
        print("AD ERROR");
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        print("AD START");
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if(placementId == "Rewarded_" + platformName && showResult == ShowResult.Finished)
        {
            print("DEJ MU DRUGOM SZANSE");
        }
    }
}
