using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class AdManager : MonoBehaviour
{
    public static AdManager instance;

    public BannerView _bannerAd;
    // Test Banner Id
    public string _bannerAdId = "ca-app-pub-3667488895645680/1673785888";

    public void Start()
    {
         showBannerAd();
         MobileAds.Initialize(initStatus => { });
    }


    public void showBannerAd()
    {
        requestBannerAd();


        _bannerAd.Show();
    }

    public void requestBannerAd()
    {
        _bannerAd = new BannerView(_bannerAdId, AdSize.Banner, AdPosition.Bottom);
        AdRequest adRequest = new AdRequest.Builder().Build();


        _bannerAd.LoadAd(adRequest);
    }

}