HiLo: Number Guessing Game

Following http://www.codeproject.com/Articles/1043237/Beginner-Tutorial-A-Unity-Number-Guessing-Game

PROCESS
	Add GUI text to canvas
	Add script component to text object
	Create InitializeGame() method
		generate random number and save to intRandomNumber
		set text of public object to welcome text
		call from Start()
	In Update()
		listen for spacebar
			then InitializeGame()
		listen for anykey
			parse to number and save to intGuessedNumber
			compare guess to random
				display text accordingly

TODO
	allow for multiple digit numbers
	display user input
		create input box
		on enter, parse to int
	Look at doc for 
		TryParse - should look at alt outcomes
		Input - should look at other methods

NOTES
	int.TryParse(Input.inputString, out intGuessedNumber)
		attempts to parse inputString to an integer, then saves it to out
		
