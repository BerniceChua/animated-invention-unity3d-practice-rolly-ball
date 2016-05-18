using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 cameraOffset;

	// Use this for initialization
	void Start () {
		cameraOffset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	// LateUpdate is called once per frame ONLY AFTER all the other calculations are done.
	void LateUpdate () {
		transform.position = player.transform.position + cameraOffset;
	}
}
