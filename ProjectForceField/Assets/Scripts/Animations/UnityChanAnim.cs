using UnityEngine;
using System.Collections;

public class UnityChanAnim : MonoBehaviour {
	Animator anim;
	WalkMechanics walkMechanics;

	void Start() {
		anim = GetComponent<Animator> ();
		walkMechanics = GetComponent<WalkMechanics> ();
	}

	void Update() {
		anim.SetBool ("isWalking", walkMechanics.getIsWalking ());
		anim.SetBool ("isRunning", walkMechanics.getIsRunning ());
	}
}
