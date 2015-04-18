using UnityEngine;
using System.Collections;

public class cameraControl : MonoBehaviour {

	public Vector2 xyLimit;

	private Vector3 touchPoint;

	void Start () {

	}

	void Update () {
		//limitations of camera movement
		Camera.main.transform.position = new Vector3 (Mathf.Clamp(Camera.main.transform.position.x, -xyLimit.x, xyLimit.x), Mathf.Clamp(Camera.main.transform.position.y, -xyLimit.y, xyLimit.y), -10);
	}

	void OnMouseDown()
	{
		touchPoint = Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
	}

	void OnMouseDrag() {
		Vector3 deltaPos = touchPoint - Camera.main.ScreenToWorldPoint (new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
		Vector3 newPosition = Camera.main.transform.position + deltaPos;
		Camera.main.transform.position = newPosition;
	}

	void OnMouseUp()
	{

	}
}