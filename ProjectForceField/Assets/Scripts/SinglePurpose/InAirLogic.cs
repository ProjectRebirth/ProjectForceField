using UnityEngine;
using System.Collections;

public class InAirLogic : MonoBehaviour {
	public BasePlayerStats baseStats;

	void OnTriggerEnter (Collider collider) {
		baseStats.setInAir (false);
	}

	void OnTriggerExit(Collider collider) {
		baseStats.setInAir (true);
	}

}
