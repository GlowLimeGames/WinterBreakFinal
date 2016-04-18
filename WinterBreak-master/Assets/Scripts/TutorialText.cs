using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TutorialText : MonoBehaviour {

	Text narText;
	GameObject health;
	// Use this for initialization
	void Awake () {
		narText = GetComponent<UnityEngine.UI.Text>();
		narText.text = "Ok, I'll be nice. W,A,S,D to move, mouse for camera, spacebar to ascend vertically. Spacebar to request me to revive you upon your inevitable demise. There...that's me being nice.";
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > 10)
			narText.text = "";
		if (Input.GetKey(KeyCode.Mouse0))
			narText.text = "";
	}
}
