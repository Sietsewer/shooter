using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	public Color colorDefault;
	public Color colorNightvision;
	private bool nightVisionOn = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(Keybinds.nightVision)){
			if(nightVisionOn){
				nightVisionOn = false;
				RenderSettings.fog = false;
				camera.backgroundColor = colorDefault;
			} else {
				nightVisionOn = true;
				RenderSettings.fog = true;
				camera.backgroundColor = colorNightvision;
			}
		}
	}
	/*
	void OnPreRender () {
		if(nightVisionOn){
			RenderSettings.fog = true;
			camera.backgroundColor = colorNightvision;
		}
	}
	
	void OnPostRender () {
		if(nightVisionOn){
			RenderSettings.fog = false;
			camera.backgroundColor = colorDefault;
		}
*/
}
