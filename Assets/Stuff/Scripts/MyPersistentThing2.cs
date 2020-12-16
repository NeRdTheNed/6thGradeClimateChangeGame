using UnityEngine;
using System.Collections;

public class MyPersistentThing2 : MonoBehaviour
{
	public static MyPersistentThing2 Instance;
	
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