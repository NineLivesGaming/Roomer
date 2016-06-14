using UnityEngine;
using System.Collections;

public class roomMaster : MonoBehaviour {

	private int spawnPoint;
	private gameMaster GM;

	public GameObject playerPrefab;

	public GameObject player;

	[System.Serializable]
	public class spawnArray
	{
		public float[] points = new float[2];
	}
	public spawnArray[] spawnPoints;

	void Start () {
	}

	void Awake(){
		GM = GameObject.FindWithTag("GameMaster").GetComponent<gameMaster>();
		spawnPoint = GM.getSpawnPoint ();

		respawnPlayer (false);
	}

	public void respawnPlayer(bool resetHealth){
		player = GameObject.FindWithTag ("Player");
		if(player == null){
			Instantiate (playerPrefab);
			player = GameObject.FindWithTag ("Player");
		}
		if(resetHealth){
			GM.addHealth (99);
		}
		player.transform.position = new Vector3 (spawnPoints [spawnPoint].points[0], spawnPoints [spawnPoint].points[1], -1);
		//player.transform.localPosition.Set (spawnPoints [spawnPoint].points[0], spawnPoints [spawnPoint].points[1], -1);
	}

	void Update () {
	
	}
}
