using UnityEngine;
using System.Collections;

public class ViewController : MonoBehaviour {
	public ViewMechanics viewMechanics;

	private float lastHorizontalInput;
	private float lastVerticalInput;

	// Update is called once per frame
	void Update () {
		lastHorizontalInput = Input.GetAxisRaw ("Mouse X");
		lastVerticalInput = Input.GetAxisRaw ("Mouse Y");

		viewMechanics.lookVertical (lastVerticalInput);
		viewMechanics.lookHorizontal (lastHorizontalInput);


	}
}
