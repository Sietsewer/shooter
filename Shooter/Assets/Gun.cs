using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	public float fireDelay = 0.25f;
	public bool semiAutomatic = false;
	public GameObject flash;
	public float flashTime = 0.01f;
	public ParticleSystem muzzle;
	private bool flashOn = false;
	private float timeCount = 0.0f;
	private AudioSource audioSource;
	public AudioClip clip;
	public AudioClip unCock;
	public AudioClip cock;
	public Transform defaultPos;
	public Transform firePos;
	public GameObject gun;
	public Ammo ammo;
	public bool persistantChamber;
	public bool commonPool;
	public bool cocked = true;
	private bool reloading;
	public float reloadTime = 1.0f;
	private float reloadStart;


	// Use this for initialization
	void Start () {
		audioSource = (AudioSource)gameObject.GetComponent<AudioSource>();
		//defaultPos = (Transform)Instantiate(this.gameObject.transform);
		this.gun.transform.localPosition = defaultPos.localPosition;
		this.gun.transform.localRotation = defaultPos.localRotation;
	}
	
	// Update is called once per frame
	void Update () {
		timeCount += Time.deltaTime;
		if(flashOn && timeCount > flashTime){
			flashOn = false;
			flash.light.enabled = false;
			SlerpSetpos(this.defaultPos.localPosition, this.defaultPos.localRotation, 1.0f);
			//Quaternion.Slerp(this.gameObject.transform.rotation, this.defaultPos.transform.rotation, this.flashTime);
			//Vector3.Slerp(this.gameObject.transform.position, this.defaultPos.position, this.flashTime);
		}
		if(!reloading){
			if (semiAutomatic){
				if(Input.GetKeyDown(Keybinds.firePrimary)){
					if(timeCount > fireDelay){
						timeCount = 0.0f;
						Shoot();
					}
				}
			} else {
				if(Input.GetKey(Keybinds.firePrimary)){
					if(timeCount > fireDelay){
						timeCount = 0.0f;
						Shoot();
					}
				}
			}
		} else {
			if(Time.time - reloadStart > reloadTime){
				if(nextAmmoIndex > -1){
					ammo.reload(nextAmmoIndex);
				} else {
					ammo.reload();
				}
				cocked = true;
				reloading = false;
			} else {
			}
		}
		slerpUpdate();
	}

	private int nextAmmoIndex = -1;
	public void reload(){
		reloading = true;
		reloadStart = Time.time;
		audioSource.PlayOneShot(cock);
		nextAmmoIndex = -1;
	}

	public void reload(int index){
		reloading = true;
		reloadStart = Time.time;
		audioSource.PlayOneShot(cock);
		nextAmmoIndex = index;
	}

	private Vector3 targetPos;
	private Quaternion targetRot;
	private Vector3 currentPos;
	private Quaternion currentRot;
	private float moveTime;
	private float startTime;
	private bool moving = false;
	private void slerpUpdate(){
		if (moving){
			float fracComplete = (Time.time - startTime) / moveTime;
			if(fracComplete >= 1.0f){
				fracComplete = 1.0f;
				moving = false;
			}
			this.gun.transform.localRotation = Quaternion.Slerp(currentRot, targetRot, fracComplete);
			this.gun.transform.localPosition = Vector3.Slerp(currentPos, targetPos, fracComplete);
		}
	}
	private void SlerpSetpos(Vector3 _targetPos, Quaternion _targetRot, float _moveTime){
		moveTime = _moveTime;
		targetPos = _targetPos;
		targetRot = _targetRot;
		currentPos = this.gun.transform.localPosition;
		currentRot = this.gun.transform.localRotation;
		startTime = Time.time;
		moving = true;
	}

	void Shoot () {
		if(ammo.currentMagazine.ammo > 0 && cocked){
			ammo.currentMagazine.ammo--;
			audioSource.PlayOneShot(clip);
			flash.light.enabled = true;
			muzzle.Play();
			flashOn = true;
			SlerpSetpos(this.firePos.localPosition, this.firePos.localRotation, 1.0f);
		} else {
			if(cocked){
				audioSource.PlayOneShot(unCock);
				cocked = false;
			}
		}
	}
}
