using GoogleMobileAds.Api;
using UnityEngine;

public class AdManager : MonoBehaviour
{
    private static AdManager adInstance;
        
    void Awake(){
        DontDestroyOnLoad (this);
         
        if (adInstance == null) {
            adInstance = this;
        } else {
            DestroyObject(gameObject);
        }
    }

    private BannerView bannerView;

    // Use this for initialization
    void Start()
    {
        #if UNITY_ANDROID
                string appId = "ca-app-pub-3983053491434538~5470509914";
        #elif UNITY_IPHONE
                            string appId = "ca-app-pub-3983053491434538~5470509914";
        #else
                string appId = "unexpected_platform";
        #endif

        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(appId);

        #if UNITY_ANDROID
                string adUnitId = "ca-app-pub-3983053491434538/7114640366";
        #elif UNITY_IPHONE
                            string adUnitId = "ca-app-pub-3983053491434538/7114640366";
        #else
                string adUnitId = "unexpected_platform";
        #endif

        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(adUnitId, AdSize.Banner, AdPosition.Bottom);

        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();

        // Load the banner with the request.
        bannerView.LoadAd(request);
    }

   
}
