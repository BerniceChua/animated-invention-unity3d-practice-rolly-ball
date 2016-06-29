using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StartGame : MonoBehaviour {
	
	public Button play;

	// Use this for initialization
	public void Start() {
		play.onClick.AddListener (() => {
			this.gameObject.SetActive(false);
		});
	}
}