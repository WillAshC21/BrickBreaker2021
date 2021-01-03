using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Retry : MonoBehaviour {

	public void LoadGame() {
		Score.score = 0;
		Lives.lives = 3;
		Application.LoadLevel("Stage_1");
	}

	public void ExitGame() {
		Application.Quit();
	}
}
