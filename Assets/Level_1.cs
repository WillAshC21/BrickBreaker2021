using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_1 : MonoBehaviour {

	void Update () {
		if (Score.score == 450) {
			Application.LoadLevel("Stage_2");
		}
	}
}
