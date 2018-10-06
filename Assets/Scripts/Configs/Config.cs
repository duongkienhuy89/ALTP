using UnityEngine;
using System.Collections;

public class Config  {

#if UNITY_IPHONE
	public static string adsInIDGameOver = "ca-app-pub-2127327600096597/2550957266";
	public static string adsInIDBanner = "ca-app-pub-2127327600096597/8097963269";

#endif

#if UNITY_ANDROID

	public static string appId = "ca-app-pub-3940256099942544~3347511713";
	public static string adsInIDGameOver = "ca-app-pub-3940256099942544/1033173712";
	public static string adsInIDBanner = "ca-app-pub-3940256099942544/6300978111";
  



#endif

}
