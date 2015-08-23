using UnityEngine;
using System.Collections;

public class WalkController : MonoBehaviour {
	public WalkMehanics walkMechanics;

	private float lastVerticalInput;
	private float lastHorizontalInput;

	// Update is called once per frame
	void Update () {
		lastHorizontalInput = Input.GetAxisRaw ("Horizontal");
		lastVerticalInput = Input.GetAxisRaw ("Vertical");

		walkMechanics.walkForward (lastVerticalInput);
		walkMechanics.walkSide (lastHorizontalInput);
	}
}
