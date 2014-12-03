using UnityEngine;
using System.Collections;

public class GrenadeThrow : MonoBehaviour {

	// Use this for initialization
	public GameObject grenade;
	public float force = 5.0f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(Keybinds.grenade)){
			GameObject thrown = (GameObject)Instantiate(grenade, this.transform.position, Quaternion.identity);
			thrown.rigidbody.AddForce(transform.forward*this.force);
		}
	}
}
