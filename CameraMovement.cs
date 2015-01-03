using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

	Transform target;

	void Start () {

		target = GameObject.FindGameObjectWithTag ("Player").transform;
	
	}

	void LateUpdate () {

		transform.position = target.position + new Vector3 (0, 0, -10);
		Debug.Log("Kamera OK");
	}
}
