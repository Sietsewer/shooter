using UnityEngine;
using System.Collections;

public class BoltExplosion : MonoBehaviour {
	public ParticleSystem flash;
	public ParticleSystem gasExplosion;
	public ParticleSystem sparks;
	private float timeStart;
	public float liveTime = 3.0f;

	// Use this for initialization
	void Start () {
		timeStart = Time.time;
		flash.Play();
		gasExplosion.Play();
		sparks.Play();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time - timeStart > liveTime){
			Destroy(this.gameObject);
		}
	}
}
