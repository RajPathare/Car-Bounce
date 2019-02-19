using System;
using UnityEngine;
using GoogleMobileAds.Api;

// Example script showing how to invoke the Google Mobile Ads Unity plugin.
public class VidAd : MonoBehaviour
{
    
    private RewardBasedVideoAd rewardBasedVideo;
    public static int showw = 0;
   

    public void Start()
    {

#if UNITY_ANDROID
        string appId = "ca-app-pub-3983053491434538~5470509914";
#elif UNITY_IPHONE
        string appId = "ca-app-pub-3983053491434538~5470509914";
#else
        string appId = "unexpected_platform";
#endif

        //MobileAds.SetiOSAppPauseOnBackground(true);

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        // Get singleton reward based video ad reference.
        this.rewardBasedVideo = RewardBasedVideoAd.Instance;

        this.RequestRewardBasedVideo();

        // RewardBasedVideoAd is a singleton, so handlers should only be registered once.
        this.rewardBasedVideo.OnAdLoaded += this.HandleRewardBasedVideoLoaded;
        this.rewardBasedVideo.OnAdFailedToLoad += this.HandleRewardBasedVideoFailedToLoad;
        this.rewardBasedVideo.OnAdOpening += this.HandleRewardBasedVideoOpened;
        this.rewardBasedVideo.OnAdStarted += this.HandleRewardBasedVideoStarted;
        this.rewardBasedVideo.OnAdRewarded += this.HandleRewardBasedVideoRewarded;
        this.rewardBasedVideo.OnAdClosed += this.HandleRewardBasedVideoClosed;
        this.rewardBasedVideo.OnAdLeavingApplication += this.HandleRewardBasedVideoLeftApplication;
    }

    public void hmm() {

        showw = 1;

    }


    public void OnGUI()
    {
        this.ShowRewardBasedVideo();
      
    }

    // Returns an ad request with custom ad targeting.

    /*private AdRequest CreateAdRequest()
    {
        /*return new AdRequest.Builder()
            .AddTestDevice(AdRequest.TestDeviceSimulator)
            .AddTestDevice("0123456789ABCDEF0123456789ABCDEF")
            .AddKeyword("game")
            .SetGender(Gender.Male)
            .SetBirthday(new DateTime(1985, 1, 1))
            .TagForChildDirectedTreatment(false)
            .AddExtra("color_bg", "9B30FF")
            .Build();


        //return new AdRequest.Builder().Build();
    }*/
        

    private void RequestRewardBasedVideo()
    {
#if UNITY_ANDROID
        string adUnitId = "ca-app-pub-3983053491434538/4301571231";
#elif UNITY_EDITOR
        string adUnitId = "ca-app-pub-3983053491434538/6388614884";
#elif UNITY_IPHONE
        string adUnitId = "ca-app-pub-3983053491434538/6388614884";
#else
        string adUnitId = "unexpected_platform";
#endif

        // Create an empty ad request
        AdRequest request = new AdRequest.Builder().Build();

        //this.rewardBasedVideo.LoadAd(this.CreateAdRequest(), adUnitId);
        this.rewardBasedVideo.LoadAd(request, adUnitId);
    }


    private void ShowRewardBasedVideo()
    {
        if (showw == 0)

        {
            //this.rewardBasedVideo.Show();


        }
        else if (showw == 1) {
            this.rewardBasedVideo.Show();
            showw = 0;

        }




    }

    

    #region RewardBasedVideo callback handlers

    public void HandleRewardBasedVideoLoaded(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLoaded event received");
    }

    public void HandleRewardBasedVideoFailedToLoad(object sender, AdFailedToLoadEventArgs args)
    {
        MonoBehaviour.print(
            "HandleRewardBasedVideoFailedToLoad event received with message: " + args.Message);
    }

    public void HandleRewardBasedVideoOpened(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoOpened event received");
    }

    public void HandleRewardBasedVideoStarted(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoStarted event received");
    }

    public void HandleRewardBasedVideoClosed(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoClosed event received");
    }

    public void HandleRewardBasedVideoRewarded(object sender, Reward args)
    {
        string type = args.Type;
        double amount = args.Amount;
        MonoBehaviour.print(
            "HandleRewardBasedVideoRewarded event received for " + amount.ToString() + " " + type);
    }

    public void HandleRewardBasedVideoLeftApplication(object sender, EventArgs args)
    {
        MonoBehaviour.print("HandleRewardBasedVideoLeftApplication event received");
    }

    #endregion
}