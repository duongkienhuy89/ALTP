using UnityEngine;
using System.Collections;

public class Config  {

#if UNITY_IPHONE
	public static string adsInIDGameOver = "ca-app-pub-2127327600096597/2550957266";
	public static string adsInIDBanner = "ca-app-pub-2127327600096597/8097963269";

#endif

#if UNITY_ANDROID

	public static string adsInIDGameOver = "ca-app-pub-2127327600096597/7551854172";
	public static string adsInIDBanner = "ca-app-pub-2127327600096597/9063426863";
  



#endif

}
