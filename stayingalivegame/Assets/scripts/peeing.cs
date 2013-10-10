using UnityEngine;
using System.Collections;

public class peeing : MonoBehaviour {
float timevariable1 = 0f;
float timevariable2 = 1000f;
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.B)) {
			if (Time.time < timevariable2 && Time.time > timevariable1) {
				timevariable1 = Time.time + 5f;
				timevariable2 = timevariable1 + 1f;
			}
			
			else {
				if (Time.time > timevariable2 || Time.time < timevariable1) {
					renderer.material.color = Color.yellow;
				}	
			}
		}
	
	}
}
