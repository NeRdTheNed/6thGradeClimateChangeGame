using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour
{
	public string nameThe;
	public bool button1ForThisScript;
	public bool button2ForThisScript;
	public bool button3ForThisScript;

	public bool optionsForThis;

	public float numBetween1And3;

	public Sprite sprite1p1;
	public Sprite sprite1p2;
	public Sprite sprite2p1;
	public Sprite sprite2p2;
	public Sprite sprite3p1;
	public Sprite sprite3p2;
	
	private SpriteRenderer spriteRenderer; 

		// Use this for initialization
		void Start ()
		{
		spriteRenderer = GetComponent<SpriteRenderer>();
		}
	
		// Update is called once per frame
		void Update ()
		{

		GameObject go2 = GameObject.Find(nameThe);
		button1ForThisScript = go2.GetComponent<Pause>().button1;
		button2ForThisScript = go2.GetComponent<Pause>().button2;
		button3ForThisScript = go2.GetComponent<Pause>().button3;

		optionsForThis = go2.GetComponent<Pause> ().options;

		if(numBetween1And3 == 1 && button1ForThisScript == true)
		{
			if(optionsForThis == true)
			{
				spriteRenderer.sprite = sprite1p2;
			} else 
			{
				spriteRenderer.sprite = sprite1p1;
			}
		}

		if(numBetween1And3 == 2 && button2ForThisScript == true)
		{
			if(optionsForThis == true)
			{
				spriteRenderer.sprite = sprite2p2;
			} else 
			{
				spriteRenderer.sprite = sprite2p1;
			}
		}

		if(numBetween1And3 == 3 && button3ForThisScript == true)
		{
			if(optionsForThis == true)
			{
				spriteRenderer.sprite = sprite3p2;
			} else 
			{
				spriteRenderer.sprite = sprite3p1;
			}
		}

		if (button1ForThisScript == false && button2ForThisScript == false && button3ForThisScript == false)
		{
			spriteRenderer.sprite = null;
		}
	
		}
}

