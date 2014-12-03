using UnityEngine;
using System.Collections;

public class CameraOverlay : MonoBehaviour {
	// Use this for initialization
	public Texture overlayTexture;
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI(){
		if(GlobalFlags.NightVision){
			GUI.DrawTexture(new Rect(0, 0, Screen.width, Screen.height), overlayTexture, ScaleMode.StretchToFill, true, 10.0F);
		}
	}
}
