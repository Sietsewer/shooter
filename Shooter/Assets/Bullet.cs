using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Bullet : MonoBehaviour {
	private Vector3 lastPosition;
	public GameObject particles;
	public float damage = 60.0f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(lastPosition != null){
			RaycastHit hit;
			Physics.Linecast(lastPosition, transform.position, out hit, 2561);
			if(hit.collider != null && hit.collider.gameObject.tag != "Player"){
				Debug.Log("Hit! - " + hit.collider.gameObject.name);
				HealthSystem health = hit.collider.GetComponent<HealthSystem>();
				if(health != null){
					health.currentHealth -= damage;
				}
				damage *= 0.5f;
				Instantiate(particles,hit.point, Quaternion.LookRotation(hit.normal));
				if(hit.collider.gameObject.tag != "CanPenatrate"){
					Destroy(this.gameObject, 2.0f);
				}
			}
		}
		lastPosition = transform.position;
	}
}
