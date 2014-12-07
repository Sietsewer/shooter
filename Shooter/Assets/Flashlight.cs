using UnityEngine;
using System.Collections;

public class Flashlight : MonoBehaviour {

	// Use this for initialization
	public IconController icon;
	public Keybinds keybinds;
	public bool lightOn = true;
	public GameObject aimPoint;
	public GameObject startPoint;
	public GameObject pointLight;
	void Start () {
		icon.IsChecked = lightOn;
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		RaycastHit hitClose;
		Physics.Linecast(startPoint.transform.position, aimPoint.transform.position, out hit);
		Physics.Linecast(this.transform.position, aimPoint.transform.position, out hitClose);
		if(hit.collider != null){
			pointLight.transform.position = hit.point;
		} else {
			if(hitClose.collider != null){
				pointLight.transform.position = startPoint.transform.position;
			} else {
				pointLight.transform.position = aimPoint.transform.position;
			}
		}
		if(Input.GetKeyDown(Keybinds.flashLight)){
			if(lightOn){
				this.light.enabled = false;
				this.transform.FindChild("PointLight").FindChild("Point light").light.enabled = false;
				icon.IsChecked = false;
				lightOn = false;
			} else {
				this.light.enabled = true;
				icon.IsChecked = true;
				this.transform.FindChild("PointLight").FindChild("Point light").light.enabled = true;

				lightOn = true;
			}
		}
	}
}
