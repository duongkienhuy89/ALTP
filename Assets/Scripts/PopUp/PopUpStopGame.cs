using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class PopUpStopGame : MonoBehaviour {

    public tk2dUIItem btnContinute;
    public tk2dUIItem btnStopGame;
    public tk2dTextMesh txtLevel;

    BannerView bannerView;
    AdRequest request;


    private void LoadAdsBanner()
    {
        // Create a 320x50 banner at the top of the screen.
        bannerView = new BannerView(
               Config.adsInIDBanner, AdSize.Banner, AdPosition.Top);
        // Create an empty ad request.

       

        request = new AdRequest.Builder().AddTestDevice(AdRequest.TestDeviceSimulator).AddTestDevice("54829CBF8D1115A66940C3B0C88A9B7E").Build();
        // Load the banner with the request.

        //id0ae30a9eb3539410624b3cd2b086379e

        // Debug.Log("device id" + SystemInfo.deviceUniqueIdentifier);
    }

    public void ShowAdsBanner()
    {
        bannerView.LoadAd(request);
        bannerView.Show();
    }

    public void HideAdsBanner()
    {
        bannerView.Hide();
    }
 

    void callResetDapAn()
    {
        DapAnController.instance.resetDapAN();
     
    }

    public void setlevel(int level)
    {
        txtLevel.text = "Vượt qua: Câu " + level;
        ShowAdsBanner();
    }


    void btnContinute_OnClick()
    {
        try
        {
           //HideOp
            GameController.instance.currentState = GameController.State.Question;
            PopupController.instance.HidePopupStop();
            HideAdsBanner();
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    void btnStopGame_onClick()
    {
        try
        {
            SoundController.Instance.PlayTamBiet();
            GameController.instance.doSave();
            callResetDapAn();
            PopupController.instance.HidePopupGameOver();
            PopupController.instance.HidePopupKhanGia();
            PopupController.instance.HidePopupNguoiThan();
            PopupController.instance.HidePopUpWin();
            PopupController.instance.HidePopupStop();
            PopupController.instance.ShowMainGame();
            TroGiupControlller.instance.resetHelp();
            GameController.instance.level = 1;
            HideAdsBanner();
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
    }



    // Use this for initialization
    void Start()
    {
        btnContinute.OnClick += btnContinute_OnClick;
        btnStopGame.OnClick += btnStopGame_onClick;
        LoadAdsBanner();
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
