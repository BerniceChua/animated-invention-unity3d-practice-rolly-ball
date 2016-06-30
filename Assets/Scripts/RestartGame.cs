using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RestartGame : MonoBehaviour {

	public Button replay;
	
	// Use this for initialization
	public void Restart() {
		replay.onClick.AddListener (() => {
			this.gameObject.SetActive(false);
		});
	}
}