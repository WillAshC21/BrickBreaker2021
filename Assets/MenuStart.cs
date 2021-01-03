using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStart : MonoBehaviour {

	public void LoadGame() {
		Application.LoadLevel("Stage_1");
	}

	public void ExitGame() {
		Application.Quit();
	}
}
