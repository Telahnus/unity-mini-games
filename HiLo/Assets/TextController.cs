using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{
    public Text display;
    public InputField input;
    int intRandomNumber;
    int intGuessedNumber;

	// Use this for initialization
	void Start ()
    {
        InitializeGame();
        input.onEndEdit.AddListener(CheckAnswer);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    // Hitting the spacebar always restarts the game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InitializeGame();
        }
	}

    private void CheckAnswer(string arg)
    {
        // Reset input field
        input.text = "";

        // Compare input to random number
        if (int.TryParse(arg, out intGuessedNumber))
        {
            if (intRandomNumber > intGuessedNumber)
            {
                display.text = string.Format("You guessed {0}. You are too low", intGuessedNumber);
            }
            if (intRandomNumber < intGuessedNumber)
            {
                display.text = string.Format("You guessed {0}. You are too high", intGuessedNumber);
            }
            if (intRandomNumber == intGuessedNumber)
            {
                display.text = string.Format("You guessed {0}.\nYou are correct!\n(press spacebar to continue)", intGuessedNumber);
            }
        }
    }

    private void InitializeGame()
    {
        // Pick a random number
        intRandomNumber = Random.Range(1, 100);
        Debug.Log(intRandomNumber);

        // Set the text to start the game
        display.text = "Geuss a number between 1 and 100";
    }

}
