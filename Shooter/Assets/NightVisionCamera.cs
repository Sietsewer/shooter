using UnityEngine;
using System.Collections;

public class NightVisionCamera : MonoBehaviour {

	private bool nightVisionOn = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(Keybinds.nightVision)){
			if(nightVisionOn){
				this.camera.enabled = false;
				nightVisionOn = false;
			} else {
				this.camera.enabled = true;
				nightVisionOn = true;
			}
		}
	}
}
