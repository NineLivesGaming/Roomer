using UnityEngine;
using System.Collections;

public class gameMaster : MonoBehaviour {

	private int maxHealth = 10, health;

	public int spawnPoint;

	public bool timeSlow = false;

	// Use this for initialization
	void Start () {
		health = maxHealth;
		spawnPoint = 0;
	}

	void Awake(){
		DontDestroyOnLoad (this);
		UnityEngine.SceneManagement.SceneManager.LoadScene ("mainMenu");
	}
	
	// Update is called once per frame
	void Update () {
	}

	public int getSpawnPoint(){
		return spawnPoint;
	}

	public void setSpawnPoint(int newSpawnPoint){
		spawnPoint = newSpawnPoint;
	}

	public void setTimeSlow(bool newTimeSlow){
		timeSlow = newTimeSlow;
	}

	public void addHealth(int hp){
		health += hp;
		if(health > maxHealth){
			health = maxHealth;
		}
	}

	public void removeHealth(int hp){
		health -= hp;
		if(health <= 0){
			//Game Over!
		}
	}
}
