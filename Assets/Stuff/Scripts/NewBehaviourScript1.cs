 using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour {
	public Sprite sprite1;
	public Sprite sprite2;
	public string nameThe;
	public bool onLight = false;
	
	private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {



		spriteRenderer = GetComponent<SpriteRenderer>(); 

	}
	
	// Update is called once per frame
	void Update () {
		GameObject go = GameObject.Find(nameThe);
		onLight = go.GetComponent<SwitchOther>().on;
		if (spriteRenderer.sprite == null) 
			spriteRenderer.sprite = sprite1; 
		if(onLight == false)
		{
			if (spriteRenderer.sprite == sprite1)
			{
				spriteRenderer.sprite = sprite2;
			}
		}
	}
}
