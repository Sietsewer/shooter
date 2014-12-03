using UnityEngine;
using System.Collections;

public class Grenade : MonoBehaviour {

	public enum Modes {Fuse, Impact};
	public Modes mode = Modes.Fuse;
	public float fuse = 5.0f;
	private bool detonated = false;
	public GameObject Explosion;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(mode == Modes.Fuse && !detonated){
			fuse-=Time.deltaTime;
			if(fuse < 0.0f){
				detonated = true;
				Instantiate(Explosion, this.transform.position, Quaternion.identity);

			}
		}

	}
}
