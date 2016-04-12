using UnityEngine;
using System.Collections;

public class cubeColorWhite : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().material.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
