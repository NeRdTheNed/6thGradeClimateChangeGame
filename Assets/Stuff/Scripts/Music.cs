using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour 
{

	public string nameThe;

	public AudioSource _AudioSource1;
	public AudioSource _AudioSource2;
	public AudioSource _AudioSource3;

	public bool source = false;
	public bool source2 = false;
	public bool source3 = false;

	public float num1 = 0;
	public float num2 = 2;
	public float num3 = 11;

	public bool makeSound = true;

	void Awake() {
		DontDestroyOnLoad(transform.gameObject);
		
		source = false;
		source2 = false;

	}
	
	void Start() 
	{
		_AudioSource1.Play();
		source = false;
		source2 = false;
		source3 = true;
	}
	
	
	void FixedUpdate () 
	{
		GameObject go2 = GameObject.Find(nameThe);
		makeSound = go2.GetComponent<Pause>().soundOn;

		if (makeSound == false)
		{
			_AudioSource1.mute = true;
			_AudioSource2.mute = true;
			_AudioSource3.mute = true;
		} else
		{
			_AudioSource1.mute = false;
			_AudioSource2.mute = false;
			_AudioSource3.mute = false;
		}

				if (Application.loadedLevel == num1) {
						if ((source == false) == true) {
				
								_AudioSource2.Stop ();
				
								_AudioSource1.Play ();

								source = true;

				source3 = false;

				source2 = false;
						}
				}
			
		if (Application.loadedLevel == num2) {
						if ((source2 == false) == true) {
					
								_AudioSource1.Stop ();
					
								_AudioSource2.Play ();


								source2 = true;

								source = false;

						}
				}


			if (Application.loadedLevel == num3) {
			if ((source3 == false) == true) {
			_AudioSource1.Stop ();
			_AudioSource2.Stop ();
			_AudioSource3.Play ();
				source3 = true;
			}
			}
			
			
	}
	
}
