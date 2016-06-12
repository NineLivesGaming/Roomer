using UnityEngine;
using System.Collections;

public class roomMaster : MonoBehaviour {

	private int spawnPoint;
	private gameMaster GM;

	public GameObject playerPrefab;

	[System.Serializable]
	public class spawnArray
	{
		public int[] points = new int[2];
	}
	public spawnArray[] spawnPoints;

	void Start () {
	}

	void Awake(){
		respawnPlayer (false);
		GM = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
		spawnPoint = GM.getSpawnPoint ();
	}

	public void respawnPlayer(bool resetHealth){
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if(player == null){
			player = Instantiate (playerPrefab);
		}
		if(resetHealth){
			GM.addHealth (99);
		}
		player.transform.localPosition.Set (spawnPoints [spawnPoint].points[0], spawnPoints [spawnPoint].points[1], -1);
	}

	void Update () {
	
	}
}
