using UnityEngine;
using System.Collections;
using GoogleMobileAds.Api;

public class PopUpGameOver : MonoBehaviour {

    public tk2dUIItem btnContinute;

    public tk2dTextMesh txtLevel;
    public tk2dTextMesh txtMaxLevel;
    InterstitialAd interstitial;

    private void LoadAdsInterstitial()
    {
        // Initialize an InterstitialAd.
		interstitial = new InterstitialAd(Config.adsInIDGameOver);
        // Create an empty ad request.
        AdRequest requestIN = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator).AddTestDevice("365BCE5DDF729BFD1E6E40D79CE8F42B").Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(requestIN);
    }

    private void ShowAdsInterstitial()
    {
        if (interstitial.IsLoaded())
        {
            interstitial.Show();
        }
    }

    void callResetDapAn()
    {
         DapAnController.instance.resetDapAN();
         
    }

    public void setlevel(int level, int maxlevel)
    {
        txtLevel.text = "Vượt qua: Câu " + level;
        txtMaxLevel.text = "Thời gian: " + maxlevel+" giây.";
        LoadAdsInterstitial();
    }


    void btnContinute_OnClick()
    {
        try
        {
            SoundController.Instance.PlayTamBiet();
            callResetDapAn();
            PopupController.instance.HidePopupGameOver();
            PopupController.instance.HidePopupKhanGia();
            PopupController.instance.HidePopupNguoiThan();
            PopupController.instance.HidePopUpWin();
            PopupController.instance.ShowMainGame();
            TroGiupControlller.instance.resetHelp();
            GameController.instance.level = 1;
           
            //callResetDapAn();
            //TroGiupControlller.instance.resetHelp();
            //PopupController.instance.HidePopupGameOver();
            //GameController.instance.setDefault();
            //GameController.instance.suget();
        }
        catch (System.Exception)
        {

            throw;
        }
        ShowAdsInterstitial();
    }

 

	// Use this for initialization
	void Start () {
        btnContinute.OnClick += btnContinute_OnClick;
      
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
