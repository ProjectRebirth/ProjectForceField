using UnityEngine;
using System.Collections;

public class ViewMechanics : MonoBehaviour {
	public float verticalSensitivity;
	public float horizontalSensitivity;
	public float upperAngle;
	public float lowerAngle;

	public void lookHorizontal(float horizontalInput) {
		transform.eulerAngles = adjustRotation (transform.eulerAngles, 'y', 
		                                        horizontalInput * horizontalSensitivity * Time.deltaTime);
	}

	public void lookVertical(float verticalInput) {
		transform.eulerAngles = adjustRotation (transform.eulerAngles, 'x', 
		                                        -verticalInput * verticalSensitivity * Time.deltaTime);
	}

	private Vector3 adjustRotation(Vector3 currentRotation, char axis, float delta) {
		float x = currentRotation.x;
		float y = currentRotation.y;
		float z = currentRotation.z;

		switch (axis) {
		case 'x':
			x += delta;
			break;

		case 'y':
			y += delta;
			break;

		case 'z':
			z += delta;
			break;

		}

		return new Vector3 (x, y, z);
	}
}
