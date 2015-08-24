using UnityEngine;
using System.Collections;

public class WalkMehanics : MonoBehaviour {
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
		Vector3 forwardDirection = viewCamera.forward;
		float xForward = forwardDirection.x;
		float zForward = forwardDirection.z;
		float xSide = zForward;
		float zSide = -xForward;

		Vector3 goalSpeed = new Vector3 (xForward, 0, zForward) * lastForwardInput + new Vector3 (xSide, 0, zSide) * lastSideInput;
		goalSpeed = goalSpeed.normalized * baseStats.walkSpeed;
		rigid.velocity = Vector3.Lerp (new Vector3 (xForward, rigid.velocity.y, zForward), goalSpeed, Time.deltaTime * baseStats.smoothAcceleration);

	}


}
