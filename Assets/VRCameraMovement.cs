using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRCameraMovement : MonoBehaviour {

	public Transform vrCamera;
	public float moveSpeed = 5.0f;  
	private CharacterController CharCont;

	// Use this for initialization
	void Start () {

		CharCont = GetComponent<CharacterController>();

	}

	// Update is called once per frame
	void Update () {

		//if (Input.GetMouseButton (0)) {
			Vector3 forward = vrCamera.TransformDirection (Vector3.forward);

		CharCont.transform.TransformDirection(forward);

		//}
	}
}
