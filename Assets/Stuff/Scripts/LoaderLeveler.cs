using UnityEngine;
using System.Collections;

public class LoaderLeveler : MonoBehaviour {
	
	public int timer11 = 0;
	public int timerEnd = 200;
	public bool level1 = false;
	public bool level2 = false;
	public bool level3 = false;

	public string nameThe;
	
	public bool debug = false;

	public string moveTo1;
	public string moveTo2;
	public string moveTo3;

	public string moveTo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		timer11 ++;
		
		if (timer11 == timerEnd | timer11 >= timerEnd)
		{
			Application.LoadLevel(moveTo);
		}
		GameObject go = GameObject.Find(nameThe);
		
		level1 = (go.GetComponent<LevelSelector>().level1 == true);
		level2 = (go.GetComponent<LevelSelector>().level2 == true);
		level3 = (go.GetComponent<LevelSelector>().level3 == true);

		if (level1 == true)
		{
			moveTo = moveTo1;
		}

		if (level2 == true)
		{
			moveTo = moveTo2;
		}

		if (level3 == true)
		{
			moveTo = moveTo3;
		}

	}
}
