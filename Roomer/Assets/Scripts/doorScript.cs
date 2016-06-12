using UnityEngine;
using System.Collections;

public class doorScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D coll) {
		if (coll.gameObject.tag == "Player" && Input.GetKeyDown("w")) {
			UnityEngine.SceneManagement.SceneManager.LoadScene (1);
		}
	}
}