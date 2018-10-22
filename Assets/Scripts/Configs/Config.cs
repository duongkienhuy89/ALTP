using UnityEngine;
using System.Collections;

public class Config  {

#if UNITY_IPHONE
	public static string appId = "ca-app-pub-2127327600096597~5144496862";
	public static string adsInIDGameOver = "ca-app-pub-2127327600096597/2550957266";
	public static string adsInIDBanner = "ca-app-pub-2127327600096597/8097963269";

#endif

#if UNITY_ANDROID

	public static string appId = "ca-app-pub-5148482490300491~7632348443";
	public static string adsInIDGameOver = "ca-app-pub-5148482490300491/9660456424";
	public static string adsInIDBanner = "ca-app-pub-5148482490300491/5517746020";
  



#endif

}
