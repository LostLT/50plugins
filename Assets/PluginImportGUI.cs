using UnityEngine;
using System.Collections;
using System;
using System.Runtime.InteropServices;

public class PluginImportGUI : MonoBehaviour {
	//Lets make our calls from the Plugin
	[DllImport ("ASimplePlugin")]
	private static extern int PrintANumber();
	
	[DllImport ("ASimplePlugin")]
	private static extern IntPtr PrintHello();
	
	[DllImport ("ASimplePlugin")]
	private static extern int AddTwoIntegers(int i1,int i2);

	[DllImport ("ASimplePlugin")]
	private static extern float AddTwoFloats(float f1,float f2);	

	void OnGUI() {

		GUI.Label(new Rect(100,100,70,30), "A number! : " + PrintANumber());
		GUI.Label(new Rect(100,150,70,30), "A word! : " + Marshal.PtrToStringAuto (PrintHello()));
		GUI.Label(new Rect(100,200,70,30), "I can add two plus two! : " + AddTwoIntegers(2,2));
		GUI.Label(new Rect(100,250,70,30), "I can add some floats! : " + AddTwoFloats(2.5f,2.5f));
	}
}
