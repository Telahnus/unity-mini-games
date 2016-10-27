readme.txt for HangMan minigame

Plan
	2D game setup
	on game startup
		canvas displays welcome and generate word button
		load dictionary of words
	clicking generate
		choose 1 random word
		display blanks according to number of letters
		display gallows
	onkeydown
		no need for input fields
			it's all guessing single letters
			just get keydowns
		check if letter is in word
			fill in blanks
			or add stick figure
		check win/loss condition

Process
	created canvas, welcome text, and button
	created gamecontrol object and script
	public method in script, attached to button onclick
		in editor, drag GCobject onto button component
		alternative, add eventlistner in script
	textasset added onto script
	start()
		splits textfile into string[]
		split using char[] delims {\r, \n}
			C# by itself would allow "\r\n"
			but Unity only allows single char delims
	generateWord()
		picks a random word from string list
		displays "_ " according to length
	onKeyDown
		if letter, convert to lowercase and save to charInput
	CheckChar
		if charInput is in charList	
			update display

ToDo
	show false guesses
	add stick figure
	add win/loss conditions