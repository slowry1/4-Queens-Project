using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class quadClick : MonoBehaviour {
	public Renderer queenRen;
	Ray ray;
	RaycastHit hit;
	GameObject tempText;
	TextMesh tempTex;
	
	public GameObject respawnPrefab;
	public GameObject[] respawns;
	public GameObject[] quadArray;
	public scoreKeeper myScoreKeeper;

	// Use this for initialization
	void Start () {
		// Initialise ray
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);	
	}
	
	// Update is called once per frame
	void Update () {
		Selection();

	}
	void OnMouseDown(){
		queenRen.enabled = true;
	
	}
	
	void Selection() {
		// Use Input.GetKeyDown() for single clicks
		if(Input.GetKeyDown(KeyCode.Mouse0)) 
		{
			// Reset ray with new mouse position
			ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
			if(Physics.Raycast(ray, out hit)) {
				if(hit.transform.tag == "c1") {
					if(scoreKeeper.queenFound == false ){
						// creates array of Queen2.1 tag objects
						respawns = GameObject.FindGameObjectsWithTag("Queen2.1");
						quadArray = GameObject.FindGameObjectsWithTag("c2");
						// loop through and destroy the gameobjects
						foreach (GameObject respawn in respawns) {
							Destroy(respawn);
						}
						foreach (GameObject quadAr in quadArray) {
							quadAr.gameObject.tag = "emptyQuad";
						}
						scoreKeeper.queenFound = true;
						scoreKeeper.queenOne = true;
					}
				}
				if(hit.transform.tag == "c2") {
					if(scoreKeeper.queenFound == false ){
						// creates array of Queen2.1 tag objects
						respawns = GameObject.FindGameObjectsWithTag("Queen1.1");
						quadArray = GameObject.FindGameObjectsWithTag("c1");
						// loop through and destroy the gameobjects
						foreach (GameObject respawn in respawns) {
							Destroy(respawn);
						}
						foreach (GameObject quadAr in quadArray) {
							quadAr.gameObject.tag = "emptyQuad";
						}
						scoreKeeper.queenFound = true;
						scoreKeeper.queenTwo = true;
					}
				}
				if(hit.transform.tag == "emptyQuad") {
					Invoke("waiting", 0.1f);
				}
		}
		// Draw a red line from camera to selected object in Scene window
		Debug.DrawLine(ray.origin, hit.point, Color.red); 
		}
	}
	void waiting(){
		myScoreKeeper.setText ();
	}

}