using UnityEngine;

public class mainMenuButtons : MonoBehaviour{

	public void exitClick(){
		Application.Quit ();
	}

	public void onCreditsClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("credits");
	}

	public void onOptionsClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("options");
	}

	public void onLoadGameClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("leadGame");
	}

	public void onStartGameClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("startGame");
	}

	public void onBackButtonClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("mainMenu");
	}
}
