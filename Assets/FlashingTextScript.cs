using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/*THIS CLASS DEALS COMPLETELY WITH MAKING CERTAIN TEXT FLASH*/
public class FlashingTextScript : MonoBehaviour {
	float blinkDurationSecs =1f;
	float blinkProgress =0f;
	float blinkStep = 0.1f;
	Text blinkingText;

	// Use this for initialization
	void Start () {	
		blinkingText = GetComponentInParent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((blinkProgress > 1)||(blinkProgress<0)) {
			blinkStep*=-1f;
		} 
		blinkProgress+=blinkStep;
		blinkingText.color = Color.Lerp (Color.yellow, Color.gray, blinkProgress);// or whatever color you choose
	}
}
