using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NumberWizard : MonoBehaviour {

	// Use this for initialization
	int max;  // highest number you can choose
	int min;     // lowest number you can choose
	int guess;
	int maxGuesses=10;

	public Text text; 
	
	void Start () {
		
	StarGame();
		
	
	
	}
	void StarGame() {
		max =1000;  // highest number you can choose
		min= 1;     // lowest number you can choose
		NextGuess();

		}
	
	public void GuessHigher(){
		min=guess;
		NextGuess();
	}

	public void GuessLower(){
		max=guess;
		NextGuess();
	}


	void NextGuess() {
		maxGuesses= maxGuesses-1;
		guess= Random.Range(min,max+1);
		text.text=guess.ToString();
		if(maxGuesses<=0) {
		SceneManager.LoadScene("Win");
	}

	}

}
