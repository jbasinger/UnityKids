using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour {

	public Camera camera;
	public Transform model;
	public CharacterController character;
	public float speed;

	private Vector3 selectedPosition;

	// Use this for initialization
	void Start () {
		selectedPosition = model.position;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton (0)) {

			Ray ray = camera.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, 100)) {
				selectedPosition = hit.point;
				selectedPosition.y = character.center.y;
				model.LookAt (hit.point);
			}

		}

		if (Vector3.Distance(selectedPosition, model.position) >= 0.5f) {
			character.Move (model.forward * speed * Time.deltaTime);
			camera.transform.position = camera.transform.position + (model.forward * speed * Time.deltaTime);
		}

	}
}
