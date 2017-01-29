using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Diagnostics;

public class PlaySong : MonoBehaviour, IPointerDownHandler {

	public GameObject AllStar, Sandstorm, Sonic;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnPointerDown (PointerEventData eventData){

		if (this.gameObject.name == "AllStar") {
			AllStar.gameObject.SetActive (true);
			Sandstorm.gameObject.SetActive (false);
			Sonic.gameObject.SetActive (false);
		} else if (this.gameObject.name == "Sandstorm") {
			AllStar.gameObject.SetActive (false);
			Sandstorm.gameObject.SetActive (true);
			Sonic.gameObject.SetActive (false);
		} else if (this.gameObject.name == "Sonic") {
			AllStar.gameObject.SetActive (false);
			Sandstorm.gameObject.SetActive (false);
			Sonic.gameObject.SetActive (true);
		}
	}
}
