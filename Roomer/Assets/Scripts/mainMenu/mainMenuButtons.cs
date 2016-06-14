using UnityEngine;

public class mainMenuButtons : MonoBehaviour{

	public void exitClick(){
		Application.Quit ();
	}

	public void onCreditsClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("creditsMenu");
	}

	public void onOptionsClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("optionsMenu");
	}

	public void onLoadGameClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("loadGameMenu");
	}

	public void onStartGameClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("startGameMenu");
	}

	public void onBackButtonClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("mainMenu");
	}

	public void onNewGameButtonClick(){
		UnityEngine.SceneManagement.SceneManager.LoadScene ("startRoom");
	}
}
