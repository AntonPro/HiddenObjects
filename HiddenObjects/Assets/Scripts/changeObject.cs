using UnityEngine;
using System.Collections;

public class changeObject : MonoBehaviour {

	public GameObject newObject;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			bool hitCollider = collider2D.OverlapPoint(mousePosition);
			
			if (hitCollider) {
				audio.Play ();
				newObject.SetActive(true);
				gameObject.renderer.enabled = false;
				this.enabled = false;
			}
		}
	}
}
