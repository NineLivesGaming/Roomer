using UnityEngine;
using System.Collections;

public class timedPlatform : MonoBehaviour {

	public int timerOffset = 0;
	public int timerSpeed = 10;
	public int timerSpeedSlow = 1;
	public int timerMax = 6000;

	public int timerStayHidden = 2000;

	public float scaleX, scaleY;

	private int count;

	private gameMaster GM;

	// Use this for initialization
	void Start () {
		count = timerOffset;
		scaleX = GetComponent<Transform>().localScale.x;
		scaleY = GetComponent<Transform>().localScale.y;
	}

	void Awake(){
		GM = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
	}
	
	// Update is called once per frame
	void Update () {
		if ((count -= ((GM.timeSlow)?timerSpeedSlow:timerSpeed)) <= 0) {
			count = timerMax + timerStayHidden;
			GetComponent<BoxCollider2D> ().enabled = false;
			GetComponent<Transform> ().localScale = new Vector3 (0,0,1);
		} else {
			if(count <= timerMax){
				GetComponent<BoxCollider2D> ().enabled = true;
			}
		}

		if(GetComponent<BoxCollider2D> ().enabled){
			float newScaleX = scaleX * ((float)count / (float)timerMax);
			newScaleX = (newScaleX > scaleX)?scaleX:newScaleX;

			float newScaleY = scaleY * ((float)count / (float)timerMax);
			newScaleY = (newScaleY > newScaleY)?scaleY:newScaleY;

			GetComponent<Transform> ().localScale = new Vector3 (newScaleX,newScaleY,1);
		}
	}
}
