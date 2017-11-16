using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;   
using UnityEditor;   

namespace am
{

public class SystemIconManager {

    static SystemIconManager s_instance = null;

    Dictionary<SystemIcon.IconType, Texture2D> m_iconAsset = null;

    private SystemIconManager(){
	m_iconAsset = new Dictionary<SystemIcon.IconType, Texture2D>();
	foreach(SystemIcon.IconType type in Enum.GetValues(typeof(SystemIcon.IconType))){
	    var texture = EditorGUIUtility.Load(type.GetAssetPath()) as Texture2D;    	    
	    m_iconAsset.Add(type, texture);
	}
    }

    public static SystemIconManager instance {
	get {
	    if(s_instance == null){ s_instance = new SystemIconManager(); }
	    return s_instance;
	}
    }

    public Texture2D GetIconTexture(SystemIcon.IconType type){ return m_iconAsset[type]; }
}

[AttributeUsage(AttributeTargets.Field)]
public sealed class AssetPathAttribute : Attribute
{	
    private readonly string name;
    public AssetPathAttribute(string name){ this.name = name; }
    public string Name { get { return name; }}
}

public static class SystemIconExtension {
    public static string GetAssetPath(this SystemIcon.IconType type){
	return typeof(SystemIcon.IconType)
	    .GetField(type.ToString())
	    .GetCustomAttributes(typeof(AssetPathAttribute), false)
	    .Cast<AssetPathAttribute>()
	    .Single().Name;
    }
}

public class SystemIcon
{ 
    public enum IconType {
	[AssetPath("icons/console.erroricon.png")]
	Error,
	[AssetPath("icons/console.infoicon.png")]
	Info,
	[AssetPath("icons/console.warnicon.png")]
	Warn,
	[AssetPath("icons/winbtn_mac_max.png")]
	DotGreen,
	[AssetPath("icons/winbtn_mac_min.png")]
	DotOrange,
	[AssetPath("icons/winbtn_mac_close.png")]
	DotRed,
	[AssetPath("icons/winbtn_mac_inact.png")]
	DotGray,
	[AssetPath("icons/welcomescreen.videotutlogo.png")]
	SpecialPlay,
	[AssetPath("icons/waitspin00.png")]
	LoadingBk00, 
	[AssetPath("icons/waitspin01.png")]
	LoadingBk01, 
	[AssetPath("icons/waitspin02.png")]
	LoadingBk02, 
	[AssetPath("icons/waitspin03.png")]
	LoadingBk03, 
	[AssetPath("icons/waitspin04.png")]
	LoadingBk04, 
	[AssetPath("icons/waitspin05.png")]
	LoadingBk05, 
	[AssetPath("icons/waitspin06.png")]
	LoadingBk06, 
	[AssetPath("icons/waitspin07.png")]
	LoadingBk07, 
	[AssetPath("icons/waitspin08.png")]
	LoadingBk08, 
	[AssetPath("icons/waitspin09.png")]
	LoadingBk09, 
	[AssetPath("icons/waitspin10.png")]
	LoadingBk10, 
	[AssetPath("icons/waitspin11.png")]
	LoadingBk11,
	[AssetPath("icons/sv_icon_dot0_pix16_gizmo.png")]
	SphereGray,
	[AssetPath("icons/sv_icon_dot1_pix16_gizmo.png")]
	SphereBlue,
	[AssetPath("icons/sv_icon_dot2_pix16_gizmo.png")]
	SphereLime,
	[AssetPath("icons/sv_icon_dot3_pix16_gizmo.png")]
	SphereGreen,
	[AssetPath("icons/sv_icon_dot4_pix16_gizmo.png")]
	SphereYellow,
	[AssetPath("icons/sv_icon_dot5_pix16_gizmo.png")]
	SphereOrange,
	[AssetPath("icons/sv_icon_dot6_pix16_gizmo.png")]
	SphereRed,
	[AssetPath("icons/sv_icon_dot7_pix16_gizmo.png")]
	SpherePurple,
	[AssetPath("icons/socialnetworks.tweet.png")]
	TweetMini,
	[AssetPath("icons/refresh.png")]
	Reload,
	[AssetPath("icons/profiler.network.png")]
	Soner,
	[AssetPath("icons/lightmeter/greenlight.png")]
	LightGreen,
	[AssetPath("icons/lightmeter/lightoff.png")]
	LightGray,
	[AssetPath("icons/lightmeter/lightrim.png")]
	LightHole,
	[AssetPath("icons/lightmeter/orangelight.png")]
	LightOrange,
	[AssetPath("icons/lightmeter/redlight.png")]
	LightRed,
	[AssetPath("icons/d_waitspin00.png")]
	LoadingWh00,
	[AssetPath("icons/d_waitspin01.png")]
	LoadingWh01,
	[AssetPath("icons/d_waitspin02.png")]
	LoadingWh02,
	[AssetPath("icons/d_waitspin03.png")]
	LoadingWh03,
	[AssetPath("icons/d_waitspin04.png")]
	LoadingWh04,
	[AssetPath("icons/d_waitspin05.png")]
	LoadingWh05,
	[AssetPath("icons/d_waitspin06.png")]
	LoadingWh06,
	[AssetPath("icons/d_waitspin07.png")]
	LoadingWh07,
	[AssetPath("icons/d_waitspin08.png")]
	LoadingWh08,
	[AssetPath("icons/d_waitspin09.png")]
	LoadingWh09,
	[AssetPath("icons/d_waitspin10.png")]
	LoadingWh10,
	[AssetPath("icons/d_waitspin11.png")]
	LoadingWh11,
    };
}
}

/*
 * Local variables:
 * compile-command: "make build"
 * End:
 */

