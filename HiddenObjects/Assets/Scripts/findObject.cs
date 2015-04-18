using UnityEngine;
using System.Collections;

public class findObject : MonoBehaviour {
	
	public GameObject partSyst, findObj, foundObj;
	ParticleSystem ps;

	void Start () {
		ps = partSyst.GetComponent<ParticleSystem> ();
		ps.renderer.sortingLayerName = "background";
		ps.renderer.sortingOrder = 6;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			bool hitCollider = collider2D.OverlapPoint(mousePosition);

			if (hitCollider) {
				ps.Play ();
				audio.Play ();
				findObj.SetActive(false);
				foundObj.SetActive(true);
				gameObject.renderer.enabled = false;
				this.enabled = false;
			}
		}
	}
}