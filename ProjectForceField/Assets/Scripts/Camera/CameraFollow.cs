using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public Transform targetFollow;
	public float verticalSensitivity = 5;
	public float horizontalSensitivity = 5;

	Vector3 offset;
	float distanceFromTarget;


	void Start() {
		offset = this.transform.position - targetFollow.position;
		distanceFromTarget = Vector3.Magnitude (offset);

	}

	void Update() {
		print (distanceFromTarget);
		transform.position = -transform.forward * distanceFromTarget + targetFollow.position;
		resetZRotation ();
	}

	void resetZRotation() {
		transform.rotation = Quaternion.Euler (transform.eulerAngles.x, transform.eulerAngles.y, 0);
	}

	public void cameraRotateHorizontal(float horizontalInput) {

		transform.Rotate (new Vector3 (0, horizontalInput * horizontalSensitivity * Time.deltaTime, 0)); 
	}

	public void cameraRotateVertical(float verticalInput) {
		transform.Rotate (new Vector3 (-verticalInput * verticalSensitivity * Time.deltaTime, 0, 0));
	}
}
