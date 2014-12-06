using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AmmoUI : MonoBehaviour {

	public Ammo ammo;
	public Text text;
	public Gun gun;
	public bool showUI = false;
	public Image image;
	public float holdTime = 0.5f;

	// Use this for initialization
	void Start () {
		this.image.enabled = showUI;
		this.text.enabled = showUI;
	}

	private float holdReloadStart;
	private bool holdReload = false;
	private int scrollIndex;
	void Update () {
		if(Input.GetKeyDown(Keybinds.reload)){
			holdReloadStart = Time.time;
		}
		if(Input.GetKey(Keybinds.reload)){
			if(Time.time - holdReloadStart > holdTime){
				holdReload = true;
				showUI = true;
				this.image.enabled = showUI;
				this.text.enabled = showUI;
			}
			if(holdReload){
				float scrollVal = Input.GetAxisRaw(Keybinds.scrollAxis);
				scrollIndex -= scrollVal > 0 ? 1 : scrollVal < 0 ? -1 : 0;
			}
		}
		string uiText = "";
		int num = 1;
		scrollIndex = scrollIndex < 0 ? 0 : scrollIndex > ammo.magazines.Length-1 ? ammo.magazines.Length - 1 : scrollIndex;
		foreach(int i in ammo.magazines){
			uiText += ((scrollIndex == num-1)?(">"):(" :")) + num + "             [" + i + "/" + ammo.maxAmmo + "]\n";
			num++;
		}
		text.text = uiText;
		if(Input.GetKeyUp(Keybinds.reload)){
			if(holdReload){
				holdReload = false;
				showUI = false;
				this.image.enabled = showUI;
				this.text.enabled = showUI;
				//ammo.reload(scrollIndex);
				gun.reload(scrollIndex);
				scrollIndex = ammo.currentMagazine.index;
			} else {
				//ammo.reload();
				gun.reload();
			}
		}
	}
}
