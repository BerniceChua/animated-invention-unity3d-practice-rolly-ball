using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour {
	
	public Button exit;

	// Use this for initialization
	public void Start() {
		exit.onClick.AddListener (() => {
			Application.Quit();
		});
	}
}