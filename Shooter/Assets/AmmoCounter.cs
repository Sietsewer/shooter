using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AmmoCounter : MonoBehaviour {
	public Text text;
	public Ammo ammo;
	// Use this for initialization
	void Start () {
			
	}
	
	// Update is called once per frame
	void Update () {
		int totalAmmo = 0;
		foreach (int i in ammo.magazines){
			totalAmmo+=i;
		}
		text.text = string.Format("{0:000} / {1:0000}",ammo.currentMagazine.ammo, totalAmmo-ammo.currentMagazine.ammo);
	}
}
