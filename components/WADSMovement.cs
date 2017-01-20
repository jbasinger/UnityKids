using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WADSMovement : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 pos = gameObject.transform.position;

		if (Input.GetKey(KeyCode.W)) {
			pos.z += speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.S)) {
			pos.z -= speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.D)) {
			pos.x += speed * Time.deltaTime;
		}

		if (Input.GetKey(KeyCode.A)) {
			pos.x -= speed * Time.deltaTime;
		}

		gameObject.transform.position = pos;

	}
}
