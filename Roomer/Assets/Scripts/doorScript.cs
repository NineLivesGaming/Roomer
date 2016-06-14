using UnityEngine;
using System.Collections;

public class doorScript : MonoBehaviour {

	public string newRoom;
	public int spawnPoint;

	private gameMaster GM;

	// Use this for initialization
	void Awake () {
		GM = GameObject.FindWithTag("GameMaster").GetComponent<gameMaster>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D coll) {
		if (coll.gameObject.tag == "Player" && Input.GetKeyDown("w")) {
			GM.setSpawnPoint (spawnPoint);
			UnityEngine.SceneManagement.SceneManager.LoadScene (newRoom);
		}
	}
}