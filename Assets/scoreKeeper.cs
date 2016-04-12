using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreKeeper : MonoBehaviour {
	public static int scoreNum;
	public static int tempNumber;
	public static bool queenFound;
	public static bool queenOne;
	public static bool queenTwo;
	public static Text myText;
	public Text tempText;
	public Text textTemp1;
	public Text textTemp2;
	
	// Use this for initialization
	void Start () {
		scoreNum = 12;
		tempNumber = 0;
		queenOne = false;
		queenFound = false;
		queenTwo = false;
	}
	public void setText(){
		scoreNum = scoreNum-1 ;
		tempText.text = scoreNum.ToString();

	}
	public void buttonClk(){
		scoreNum = scoreNum-2 ;
		tempText.text = scoreNum.ToString();
	}

	public void makeTextVisible(){
		if (tempNumber == 0) {
			tempNumber = 1;
			textTemp1.enabled = true;
		} else if (tempNumber == 1) {
			tempNumber = 2;
			textTemp2.enabled = true;
		} else {
			scoreNum = scoreNum + 2;
			tempText.text = scoreNum.ToString();
		}

	}
	// Update is called once per frame
	void Update () {
	
	}

}