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
	Add inputfield GUI
	In Start()
		input.onEndEdit.AddListener(CheckAnswer)
			onEndEdit is an event
			AddListener prevents having to check during Update
	CheckAnswer(stirng arg)
		moved parse and compare from update to here


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
	string.Format("inputs {0} and {1}", input0, input1)
		formatted string replaces {x} with proceeding inputs
	InputField.onEndEdit.AddListener(MethodCall)
		InputField can specify input type
		But onEndEdit will still assume string
		So MethodCall must take string parameter, even if input can only be int
