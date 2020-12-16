using UnityEngine;
using System.Collections;

public class MyPersistentThing : MonoBehaviour
{
	public static MyPersistentThing Instance;
	
	void Awake()
	{
		if(Instance){
			DestroyImmediate(gameObject);
		}
		else
		{
			DontDestroyOnLoad(gameObject);
			Instance = this;
		}
	}
}