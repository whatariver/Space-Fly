using UnityEngine;
using GoogleMobileAds.Api;
using UnityEngine.UI;

public class AdManagerr : MonoBehaviour
{
    public GameObject player;
    public static AdManagerr instance;


    private string _appId = "ca-app-pub-3667488895645680/2676973843";

    private string _fullScreenAdId = "ca-app-pub-3667488895645680/2676973843";

    private InterstitialAd _fullscreenAd;

    // FULLSCREENAD - START
    void requestFullScreenAd()
    {
        _fullscreenAd = new InterstitialAd(_fullScreenAdId);

        AdRequest adRequest = new AdRequest.Builder().Build();

        _fullscreenAd.LoadAd(adRequest);
    }

    void showFullScreenAd()
    {
        requestFullScreenAd();
        if (_fullscreenAd.IsLoaded())
        {
            _fullscreenAd.Show();
        }
        else
        {
            Debug.Log("FullScreenAd daha yüklenmedi!!");
        }
    }
    // FULLSCREENAD - END


    private void Update()
    {

        if (player == null)
        {
            showFullScreenAd();
            Destroy(this);
        }


    }
}