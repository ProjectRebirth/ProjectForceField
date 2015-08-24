﻿using UnityEngine;
using System.Collections;

public class BasePlayerStats : MonoBehaviour {
	public float smoothAcceleration;
	public float walkSpeed;
	public float runSpeed;
	public float jumpHeight;
	private bool inAir;

	public void setInAir(bool inAir) {
		this.inAir = inAir;
	}


	public bool getInAir() {
		return inAir;
	}
}
