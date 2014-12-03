using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ParticleSystemTimer : MonoBehaviour {
	private float timeLeft;
	
	public void Awake() {
		ParticleSystem system = GetComponent<ParticleSystem>();
		ParticleSystem subSystem = transform.GetChild(0).particleSystem;
		timeLeft = system.startLifetime + subSystem.startLifetime;
	}
	
	public void Update() {
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0) {
			GameObject.Destroy(gameObject);
		}
	}
}
