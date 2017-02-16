using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	
	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I win!");
			StartGame();
		}
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		guess = 500;
		
		print ("=========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number, any number, but don't tell me...");
		
		print ("The highest number you can choose is " + max);
		print ("The lowest number you can choose is " + min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up for higher, down for lower, and return for equal");
		max = max + 1;
		}
	
	void NextGuess () {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess + "?");
		print ("Up for higher, down for lower, and return for equal");
	}
}
