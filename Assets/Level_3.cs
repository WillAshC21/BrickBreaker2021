using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_3 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Score.score == 1040) {
			Application.LoadLevel("EndGame");
		}
	}
}
