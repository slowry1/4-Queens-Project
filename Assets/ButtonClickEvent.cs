using UnityEngine;
using System.Collections;

public class ButtonClickEvent : quadClick {
	public scoreKeeper myScoreKeeper;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void callBtnClk(){
		myScoreKeeper.buttonClk ();
	}
	public void hello(){
		Debug.Log ("It is clicked ");


	}
}
