using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_2 : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Score.score == 790) {
			Application.LoadLevel("Stage_3");
		}
	}
}
