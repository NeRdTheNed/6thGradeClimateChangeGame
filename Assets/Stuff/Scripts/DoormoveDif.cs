using UnityEngine;
using System.Collections;
//In Gtk#, create widgets that inherit Gtk.Bin and they will show up in the designer's toolbox for easy reuse.

public class DoormoveDif : MonoBehaviour {
	public float distance = 0.1f;
	public bool debug = false;
	public bool levelDoor = false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right, distance);
		RaycastHit2D hit2 = Physics2D.Raycast(transform.position, Vector2.right, distance);
		RaycastHit2D hit4 = Physics2D.Raycast(transform.position, Vector2.up, distance);

		if (hit.collider != null |hit2.collider != null |hit4.collider != null ) {

			levelDoor = true;

			if (debug == true)
			{			Debug.Log("Hi door!");

			}
				}
	}
}
