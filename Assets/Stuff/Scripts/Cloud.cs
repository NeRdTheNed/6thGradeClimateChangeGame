 using UnityEngine;
using System.Collections;

public class Cloud : MonoBehaviour {
	public Sprite sprite1;
	public Sprite sprite2;
	public string nameThe1;
	public string nameThe2;
	public bool onCloud1 = false;
	public bool onCloud2 = false;
	
	private SpriteRenderer spriteRenderer;
	// Use this for initialization
	void Start () {



		spriteRenderer = GetComponent<SpriteRenderer>(); 

	}
	
	// Update is called once per frame
	void Update () {
		GameObject go1 = GameObject.Find(nameThe1);
		GameObject go2 = GameObject.Find(nameThe2);
		onCloud1 = go1.GetComponent<SwitchOther>().on;
		onCloud2 = go2.GetComponent<SwitchOther>().on;

		if(onCloud1 == false && onCloud2 == false)
		{
			if (spriteRenderer.sprite == sprite1)
			{
				spriteRenderer.sprite = sprite2;
			}
		}
	}
}
