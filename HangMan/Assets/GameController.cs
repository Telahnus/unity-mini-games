using UnityEngine;
using UnityEngine.UI;
//using System;
using System.Collections;


public class GameController : MonoBehaviour {

    public TextAsset textFile;
    public Text blanks;
    string[] wordList;
    string word;
    char[] charList;

	// Use this for initialization
	void Start ()
    {
        char[] delims = new char[] { '\r', '\n' };
        wordList = textFile.text.Split(delims, System.StringSplitOptions.RemoveEmptyEntries);
        //wordList = textFile.text.Split(new string[] { "\r\n" });
    }
	
	// Update is called once per frame
	void Update () {}

    public void GenerateWord()
    {
        word = wordList[Random.Range(1, wordList.Length)];
        Debug.Log(word);
        charList = word.ToCharArray();
        blanks.text = "";
        for (int i=0; i<charList.Length; i++)
        {
            blanks.text += "_ ";
        }

    }
}
