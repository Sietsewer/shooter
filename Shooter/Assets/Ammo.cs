using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Ammo : MonoBehaviour {
	public int[] magazines;
	public int maxAmmo = 30;
	public Magazine currentMagazine;

	public void setFullest (){
		int max = 0;
		int index = 0;
		for(int i = 0; i < magazines.Length; i++){
			if(magazines[i] > max){
				max = magazines[i];
				index = i;
			}
		}
		currentMagazine = new Magazine(max, this.maxAmmo, index);
	}

	// Use this for initialization
	void Start () {
		currentMagazine = new Magazine(magazines[0], maxAmmo, 0);
	}

	public void reload() {
		setFullest();
	}

	public void reload(int index){
		currentMagazine = new Magazine(magazines[index], this.maxAmmo, index);
	}
	
	// Update is called once per frame
	void Update () {
		magazines[currentMagazine.index] = currentMagazine.ammo;
	}
}
