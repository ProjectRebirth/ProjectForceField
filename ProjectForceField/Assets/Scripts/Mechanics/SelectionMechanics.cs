using UnityEngine;
using System.Collections;

public class SelectionMechanics : MonoBehaviour {
	public Transform origin;
	public int[] layersActive;
	private int layerMask;

	void Update() {
		getSelectedObject ();
	}

	void getSelectedObject() {
		RaycastHit hit;
		if (Physics.Raycast (origin.transform.position, origin.forward, out hit, float.PositiveInfinity, layerMask)) {
			print ("hello");
		} else {
			print ("goodbye");
		}
	}

	void Start() {
		foreach (int i in layersActive) {
			int shift = 1 << i;
			layerMask += shift;
		}
	}
}
