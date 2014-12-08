using UnityEngine;
using System.Collections;

public class testScript : MonoBehaviour {
	public NavMeshAgent nav;
	public GameObject target;
	public HealthSystem health;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		nav.SetDestination(target.transform.position);
		if(health.dead){
			Destroy(this.gameObject);
		}
	}
}
