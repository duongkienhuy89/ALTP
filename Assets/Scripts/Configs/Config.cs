using UnityEngine;
using System.Collections;

public class Config  {

#if UNITY_IPHONE
      public static string adsInIDGameOver = "ca-app-pub-2127327600096597/6023854465";
    public static string adsInIDTrigger = "ca-app-pub-2127327600096597/1240408461";
    public static string adsInIDBanner = "ca-app-pub-2127327600096597/7640188461";

#endif

#if UNITY_ANDROID

	public static string adsInIDGameOver = "ca-app-pub-2127327600096597/7551854172";
	public static string adsInIDBanner = "ca-app-pub-2127327600096597/9063426863";
  



#endif

}
