using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class IconController : MonoBehaviour {
	private bool isChecked;
	private Image image;
	// Use this for initialization
	void Start () {
		image = gameObject.GetComponent<Image>();
		isChecked = image.fillCenter;
	}

	public bool IsChecked{
		get{
			return isChecked;
		}
		set{
			isChecked = value;
			image.fillCenter = value;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
