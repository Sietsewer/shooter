using UnityEngine;
using System.Collections;

public class Keybinds : MonoBehaviour{
	public static KeyCode flashLight;
	public static KeyCode walkForward;
	public static KeyCode walkBackward;
	public static KeyCode walkRight;
	public static KeyCode walkLeft;
	public static KeyCode jump;

	void Start(){
		flashLight	 = KeyCode.F;
		walkForward	 = KeyCode.W;
		walkBackward = KeyCode.S;
		walkRight	 = KeyCode.A;
		walkLeft	 = KeyCode.D;
		jump		 = KeyCode.Space;
	}
}
