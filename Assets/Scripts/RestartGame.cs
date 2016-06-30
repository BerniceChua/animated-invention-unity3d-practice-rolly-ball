using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour {

	public Button replay;
	public GameObject mainMenuGameObjectContainer;
	
	// Use this for initialization
	public void Restart() {
		replay.onClick.AddListener (() => {
			Application.LoadLevel(Application.loadedLevelName);
		});
	}
}