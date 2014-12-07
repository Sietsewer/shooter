using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	private Vector3 lastPosition;
	public GameObject particles;
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
				Instantiate(particles,this.transform.position, Quaternion.LookRotation(hit.normal));
				if(hit.collider.gameObject.tag != "CanPenatrate"){
					Destroy(this.gameObject, 2.0f);
				}
			}
		}
		lastPosition = transform.position;
	}
}
