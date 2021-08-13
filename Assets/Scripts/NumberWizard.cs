using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
	[SerializeField] int maxNumber = 1000;
	[SerializeField] int minNumber = 1;
	[SerializeField] TextMeshProUGUI guessBox;
	
	int guess;

	int turnNo = 0;
	bool isGuessed = false;


	// Start is called before the first frame update
	void Start()
	{
		StartGame();
	}

	void StartGame()
	{	
		turnNo = 0;
		Guess();
	}


	public void OnHigherPressed()
	{
		if (!(maxNumber <= minNumber))
		{
			minNumber = guess + 1;
			Guess();
		}
	
	}

	public void OnLowerPressed()
	{
		if (!(maxNumber <=  minNumber))
		{ 
		maxNumber = guess - 1;
		Guess();
		}
	}
	// Update is called once per frame
	void Update() { }

	void Guess()
	{
		guess = Random.Range(minNumber, maxNumber + 1);
		guessBox.text = guess.ToString();
	}
}
