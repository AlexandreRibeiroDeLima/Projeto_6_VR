using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayFPS : MonoBehaviour {

	public Text text;
	private float fps;
	private float deltaTime;

	void Start() {
		deltaTime = 0.0f;
	}

	void Update() {
		// Calculates the number of frames each second at the given frame rate. We take or 1 second divided by our delta time (the time since the frame was rendered) to see how many frames we could render each second if each frame took the same time. 
		fps = Mathf.FloorToInt(1.0f / deltaTime);
		text.text = fps.ToString();

		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
	}

}
