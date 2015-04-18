using UnityEngine;
using System.Collections;

public class moveObject : MonoBehaviour {

	public GameObject hideObj;
	public float maxPos;

	private bool move = false;

	void Start () {

	}

	void Update () {
		if (!move && Input.GetMouseButtonDown (0)) {
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			bool hitCollider = collider2D.OverlapPoint(mousePosition);
			
			if (hitCollider) {
				audio.Play ();
				hideObj.SetActive(true);
				move = true;
			}
		}

		if (move && transform.position.x < maxPos) {
			transform.Translate(Vector3.right * Time.deltaTime);
		}
	}
}