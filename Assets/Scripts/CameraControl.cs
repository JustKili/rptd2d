using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Mouse ScrollWheel") < 0f ) {
			Camera.main.orthographicSize -= Input.mouseScrollDelta.y * Time.deltaTime * 35f;
			if (Camera.main.orthographicSize > 9f) {
				Camera.main.orthographicSize = 9f;
			}
		}
		if (Input.GetAxis("Mouse ScrollWheel") > 0f ) {
			Camera.main.orthographicSize -= Input.mouseScrollDelta.y * Time.deltaTime * 35f;
			if (Camera.main.orthographicSize < 2f) {
				Camera.main.orthographicSize = 2f;
			}
		}
	}
}
