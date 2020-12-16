using UnityEngine;
using System.Collections;



public class Skip : MonoBehaviour {

	public string moveTo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown("space"))
		{
			Application.LoadLevel(moveTo);
		}
	}
}
