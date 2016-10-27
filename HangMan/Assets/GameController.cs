using UnityEngine;
using UnityEngine.UI;
//using System;
using System.Collections;
//using System.Linq;


public class GameController : MonoBehaviour {

    // variables
    public TextAsset textFile;
    public Text blanks;
    string[] wordList;
    string word;
    char[] charList;
    char charInput;
    char[] blankList;
    int misses;

	void Start ()
    {
        // Process list of words
        char[] delims = new char[] { '\r', '\n' };
        wordList = textFile.text.Split(delims, System.StringSplitOptions.RemoveEmptyEntries);
        //wordList = textFile.text.Split(new string[] { "\r\n" });
    }
	
	void Update ()
    {
        // listen for keydown
        if (Input.anyKeyDown)
        {
            if (char.IsLetter(Input.inputString[0]))
            {
                charInput = char.ToLower(Input.inputString[0]);
                CheckChar();
                //Debug.Log(charInput);
            }
        }
    }

    public void GenerateWord()
    {
        misses = 0;

        word = wordList[Random.Range(1, wordList.Length)];
        Debug.Log(word);
        charList = word.ToCharArray();

        blanks.text = "";
        blankList = new char[word.Length];
        for (int i=0; i<blankList.Length; i++)
        {
            blankList[i] = '_';
            blanks.text += blankList[i] + " ";
        }
    }

    private void CheckChar()
    {
        bool charFound = false;
        // custom for-loop is faster than Ling contains() according to https://www.dotnetperls.com/list-contains
        for (int i=0; i<charList.Length; i++)
        {
            if (charList[i] == charInput)
            {
                charFound = true;
                blankList[i] = charInput;
            }
        }
        if (charFound)
        {
            UpdateBlanks();
        }
        // hang the man!!
        else
        {
            misses++;
        }
        CheckGameState();
    }

    private void UpdateBlanks()
    {
        blanks.text = "";
        for (int i = 0; i < blankList.Length; i++)
        {
            blanks.text += blankList[i] + " ";
        }
    }

    private void CheckGameState()
    {
        if (misses >= 6)
        {

        }

    }

}
