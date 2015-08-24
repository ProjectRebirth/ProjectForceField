using UnityEngine;
using System.Collections;

public class WalkMechanics : MonoBehaviour {
	public Transform viewCamera;

	private BasePlayerStats baseStats;
	private float lastForwardInput;
	private float lastSideInput;
	private Rigidbody rigid;

	void Awake() {
		baseStats = GetComponent<BasePlayerStats> ();
		rigid = GetComponent<Rigidbody> ();
	}

	void FixedUpdate() {
		updateMovement ();
	}

	public void walkForward(float forwardInput) {
		lastForwardInput = forwardInput;
	}

	public void walkSide(float sideMovement) {
		lastSideInput = sideMovement;
	}

	void updateMovement() {
		float xForward = viewCamera.forward.x;
		float zForward = viewCamera.forward.z;
		float xSide = zForward;
		float zSide = -xForward;

		Vector3 goalSpeed = new Vector3 (xForward, 0, zForward) * lastForwardInput;
		goalSpeed += new Vector3 (xSide, 0, zSide) * lastSideInput;
		goalSpeed = goalSpeed.normalized * Mathf.Sqrt (lastSideInput * lastSideInput / 2 + lastForwardInput * lastForwardInput / 2);
		print (goalSpeed);
		goalSpeed *= baseStats.walkSpeed;
		goalSpeed += new Vector3 (0, rigid.velocity.y, 0);

		rigid.velocity = Vector3.Lerp (rigid.velocity, goalSpeed, Time.deltaTime * baseStats.smoothAcceleration);

	}

	public void jump(bool jumpPressed) {
		print (baseStats.getInAir());
		if (jumpPressed && !baseStats.getInAir ()) {
			rigid.AddForce (Vector3.up * 100 * baseStats.jumpHeight);
		}
	}
}
