using UnityEngine;
using System.Collections;

public class WalkController : MonoBehaviour {
	public WalkMechanics walkMechanics;

	private float lastVerticalInput;
	private float lastHorizontalInput;
	private bool jumpPressed;

	// Update is called once per frame
	void Update () {
		lastHorizontalInput = Input.GetAxisRaw ("Horizontal");
		lastVerticalInput = Input.GetAxisRaw ("Vertical");
		jumpPressed = Input.GetButtonDown ("Jump");

		walkMechanics.walkForward (lastVerticalInput);
		walkMechanics.walkSide (lastHorizontalInput);
		walkMechanics.jump (jumpPressed);
	}
}
