using UnityEngine;
using System.Collections;

public class Sprinting : MonoBehaviour {

	public float sprintingSpeed = 15.0f;
	private float defaultSpeed;
	public CharacterMotor chm;
	// Use this for initialization
	void Start () {
		defaultSpeed = chm.movement.maxForwardSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(Keybinds.sprint)){
			chm.movement.maxForwardSpeed = sprintingSpeed;
		} else {
			chm.movement.maxForwardSpeed = defaultSpeed;
		}
	}
}
