using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour {

	public Rigidbody2D rb;
	bool start = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space) && start == false) {
			transform.SetParent(null);
			rb.AddForce(new Vector2(200, 200));
			start = true;
		}
	}
	void Reset() {
		transform.position = new Vector2(0, -2);
	}
	IEnumerator Wait() {
		yield return new WaitForSeconds(5);
	}
	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Floor") {
			Lives.lives -= 1;
			Reset();
			StartCoroutine(Wait());
		}
	}
	
}
