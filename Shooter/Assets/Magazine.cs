using UnityEngine;
using System.Collections;

public class Magazine{
	public int ammo;
	public int maxAmmo;
	public int index;
	public Magazine (int ammo, int maxAmmo, int index){
		this.ammo = ammo;
		this.maxAmmo = maxAmmo;
		this.index = index;
	}
}
