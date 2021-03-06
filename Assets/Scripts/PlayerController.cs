﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text countText;
	public Text winText;
	public GameObject mainMenuGameObjectContainer;

	private Rigidbody rb;
	private int count;

	void Start() {
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetScoreText();
		winText.text = "";
		mainMenuGameObjectContainer.gameObject.SetActive(false);
	}

	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rb.AddForce (movement * speed);
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag("Pick Up")) {
			other.gameObject.SetActive(false);
			count += 1;
			SetScoreText();
		}
	}

	void SetScoreText() {
		countText.text = "Score: " + count.ToString();
		if (count >= 12) {
			winText.text = "You Win!!!";
			mainMenuGameObjectContainer.gameObject.SetActive(true);
		}
	}
}