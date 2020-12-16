using UnityEngine;
using System.Collections;

public class MyPersistentThing3 : MonoBehaviour
{
	public static MyPersistentThing3 Instance;
	
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