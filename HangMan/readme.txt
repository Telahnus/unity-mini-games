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
		
