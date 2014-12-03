using UnityEngine;
using System.Collections;

public class NightVisionCamera : MonoBehaviour {

	//private bool nightVisionOn = false;
	public IconController icon;
	// Use this for initialization
	void Start () {
		icon.IsChecked = GlobalFlags.NightVision;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(Keybinds.nightVision)){
			if(GlobalFlags.NightVision){
				this.camera.enabled = false;
				GlobalFlags.NightVision = false;
				icon.IsChecked = false;
			} else {
				this.camera.enabled = true;
				GlobalFlags.NightVision = true;
				icon.IsChecked = true;
			}
		}
	}
}
