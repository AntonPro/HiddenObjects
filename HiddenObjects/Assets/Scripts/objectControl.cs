﻿using UnityEngine;
using System.Collections;

public class objectControl : MonoBehaviour {

	private GameObject camera;

	private Vector3 screenPoint;
	private Vector3 offset;

	void Start () {

	}

	void Update () {

	}

	void OnMouseDown()
	{
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);

		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}

	void OnMouseDrag() {

		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;

		transform.position = curPosition;
	}
}