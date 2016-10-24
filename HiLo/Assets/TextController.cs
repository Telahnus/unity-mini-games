using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{
    public Text objText;
    int intRandomNumber;
    int intGuessedNumber;

	// Use this for initialization
	void Start ()
    {
        InitializeGame();
	}
	
	// Update is called once per frame
	void Update ()
    {
	    // Hitting the spacebar always restarts the game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InitializeGame();
        }
        
        // Detect that a keystroke was pressed
        if (Input.anyKeyDown)
        {
            // Test to see if the keystroke was a number
            if (int.TryParse(Input.inputString, out intGuessedNumber))
            {
                if (intRandomNumber > intGuessedNumber)
                {
                    objText.text = string.Format("You guessed {0}. You are too low", intGuessedNumber);
                }
                if (intRandomNumber < intGuessedNumber)
                {
                    objText.text = string.Format("You guessed {0}. You are too high", intGuessedNumber);
                }
                if (intRandomNumber == intGuessedNumber)
                {
                    objText.text = string.Format("You guessed {0}.\nYou are correct!\n(press spacebar to continue)", intGuessedNumber);
                }
            }
        }
	}

    private void InitializeGame()
    {
        // Pick a random number
        intRandomNumber = Random.Range(1, 10);

        // Set the text to start the game
        objText.text = "Geuss a number between 1 and 10";
    }

}
