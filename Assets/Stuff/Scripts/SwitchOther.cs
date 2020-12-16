using UnityEngine;
using System.Collections;
//In the C# compiler options, defines should be separated by commas e.g. VERBOSE,MONO,ETC.

public class SwitchOther : MonoBehaviour {
	public bool switchDebug = false;
	public bool on = true;
	public float distance = 0.1f;
	public Sprite sprite1; // Drag your first sprite here
	public Sprite sprite2; // Drag your second sprite here
	
	private SpriteRenderer spriteRenderer; 
	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = sprite1; // set the sprite to sprite1
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D hit = Physics2D.Raycast(transform.position, -Vector2.right, distance);
		RaycastHit2D hit2 = Physics2D.Raycast(transform.position, Vector2.right, distance);
		RaycastHit2D hit3 = Physics2D.Raycast(transform.position, -Vector2.up, distance);
		RaycastHit2D hit4 = Physics2D.Raycast(transform.position, Vector2.up, distance);

		if (hit.collider != null |hit2.collider != null |hit3.collider != null |hit4.collider != null ) {
			on = false;
			if (switchDebug == true)
			{
				Debug.Log("Hi switch!");
			}

	}
		if (on == false)
		{
			spriteRenderer.sprite = sprite2;

		}

		if (on == true)
		{
			spriteRenderer.sprite = sprite1;
		}
}
}
