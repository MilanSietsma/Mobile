using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdsManager : MonoBehaviour, IUnityAdsListener
{
#if UNITY_IOS
    string gameID = "4771868";
#else
    string gameID = "4771869";
#endif

    void Start()
    {
        Advertisement.Initialize(gameID);
        Advertisement.AddListener(this);
        ShowBanner();
    }

    public void PlayAd()
    {
        if (Advertisement.IsReady("Interstitial_Android"))
        {
            Debug.Log("Show Ad");
            Advertisement.Show("Interstitial_Android");
        }
    }

    public void PlayRewardedAd()
    {
        if (Advertisement.IsReady("Rewarded_Android"))
        {
            Advertisement.Show("Rewarded_Android");
        }
        else
        {
            Debug.LogWarning("Rewarded ad is not ready");
        }
    }

    public void ShowBanner()
    {
        if (Advertisement.IsReady("Banner_Android"))
        {
            Advertisement.Banner.SetPosition(BannerPosition.TOP_CENTER);
            Advertisement.Banner.Show("Banner_Android");
        }
        else
        {
            StartCoroutine(RepeatShowBanner());
        }
    }

    IEnumerator RepeatShowBanner()
    {
        yield return new WaitForSeconds(1);
        ShowBanner();
    }

    public void OnUnityAdsReady(string placementId)
    {
        Debug.Log("ADS ARE READY!");
    }

    public void OnUnityAdsDidError(string message)
    {
        Debug.LogError("ERROR" + message);
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        Debug.Log("VIDEO STARTED");
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if (placementId == "Rewarded_Android" && showResult == ShowResult.Finished)
        {
            Debug.Log("PLAYER SHOULD BE REWARDED");
        }
    }
}
