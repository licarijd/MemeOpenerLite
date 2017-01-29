using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Diagnostics;

public class OpenAllMemes : MonoBehaviour, IPointerDownHandler {

	public GameObject defaultText, loadingText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


	}

	public void OnPointerDown (PointerEventData eventData){
		defaultText.gameObject.SetActive (false);
		loadingText.gameObject.SetActive (true);

		foreach (string file in System.IO.Directory.GetFiles("Assets")){
			if (file.Contains(".jpg") || file.Contains("jpeg") || file.Contains("png")){
				Process.Start (file);
			}
		}
	}

}
