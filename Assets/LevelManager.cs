using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void Loadlevel(string name){

	Debug.Log("Level load requested for:" + name);
	SceneManager.LoadScene(name);

	}


	public void QuitGame() {

	Debug.Log("Quit");
	Application.Quit();

	}

	public void Reset() {
	SceneManager.LoadScene(name);
	}




	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
