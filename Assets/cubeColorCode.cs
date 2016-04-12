using UnityEngine;
using System.Collections;

public class cubeColorCode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Renderer>().material.color = Color.gray;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
