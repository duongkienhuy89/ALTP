﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using GoogleMobileAds;
using GoogleMobileAds.Api;

public class MaxScore : MonoBehaviour {


    public tk2dUIItem btnXepHang;
    public tk2dUIItem btnHome;
	public tk2dUIItem btnHoiNgu;
	public tk2dUIItem btnLichVanNien;
    public tk2dTextMesh txtCau;

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


    public void setData()
    {
        ShowAdsBanner();
        string cau="Câu "+DataController.GetHightScore();
        txtCau.text = cau;

    }


    public void btnXepHang_OnClick()
    {
        HideAdsBanner();
        SceneManager.LoadScene("Rank");
    }

    public void btnHome_OnClick()
    {
        PopupController.instance.ShowMainGame();
        PopupController.instance.HidePopupMaxScore();
        HideAdsBanner();
    }

	public void btnHoiNgu_OnClick()
	{
		ShareRate.RateHoiNgu ();
	}
	public void btnLichVanNien_OnClick()
	{
		ShareRate.RateLVN ();
	}

	// Use this for initialization
	void Start () {
        btnXepHang.OnClick += btnXepHang_OnClick;
        btnHome.OnClick += btnHome_OnClick;
		btnHoiNgu.OnClick += btnHoiNgu_OnClick;
		btnLichVanNien.OnClick += btnLichVanNien_OnClick;
        LoadAdsBanner();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
