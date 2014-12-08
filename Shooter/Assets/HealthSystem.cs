using UnityEngine;
using System.Collections;

public class HealthSystem : MonoBehaviour {
	public float maxHealth = 100.0f;
	public float currentHealth = 100.0f;

	public bool dead{
	get{
			return currentHealth <= 0.0f;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
