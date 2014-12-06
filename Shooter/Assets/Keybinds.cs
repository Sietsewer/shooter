using UnityEngine;
using System.Collections;

public class Keybinds : MonoBehaviour{
	public static KeyCode flashLight;
	public static KeyCode walkForward;
	public static KeyCode walkBackward;
	public static KeyCode walkRight;
	public static KeyCode walkLeft;
	public static KeyCode jump;
	public static KeyCode nightVision;
	public static KeyCode grenade;
	public static KeyCode firePrimary;
	public static KeyCode reload;
	public static string scrollAxis;

	void Start(){
		flashLight	 = KeyCode.F;
		walkForward	 = KeyCode.W;
		walkBackward = KeyCode.S;
		walkRight	 = KeyCode.A;
		walkLeft	 = KeyCode.D;
		jump		 = KeyCode.Space;
		nightVision	 = KeyCode.N;
		grenade		 = KeyCode.G;
		firePrimary	 = KeyCode.Mouse0;
		reload		 = KeyCode.R;
		scrollAxis	 = "Mouse ScrollWheel";
	}
}
