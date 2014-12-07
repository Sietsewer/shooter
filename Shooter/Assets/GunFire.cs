using UnityEngine;
using System.Collections;

public class GunFire : MonoBehaviour {
	//public ParticleSystem fireEffect;
	public Bullet bullet;
	public float force = 100.0f;
	void Start () {
	
	}

	public void fire () {
		Bullet thrown = (Bullet)Instantiate(bullet, this.transform.position, Quaternion.identity);
		thrown.gameObject.rigidbody.AddForce(transform.forward*force);
	}
}
