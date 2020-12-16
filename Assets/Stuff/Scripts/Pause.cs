using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour
{

	public bool button1 = false; //back to game for first, back to main menu for second
	public bool button2 = false; //options, music for second
	public bool button3 = false; //quit for first, sound effects for second

	public bool onMenu = false;

	public bool moved = false;

	public bool firstOpenMain = false;

	public bool opening = false; //main
	public bool options = false; //options

	public string moveTo; //quit

	public bool debug = false;

	public bool soundOn = true;
	public bool soundEffectsOn = true;

	public static Pause Instance;
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

		// Use this for initialization
		void Start ()
		{

		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKeyDown ("q")) {
						opening = !opening;
				}

		MenuUpdate();
		}

	void closeMenu()
	{

		//close the menu
		opening = false;
		options = false;
		button1 = false;
		button2 = false;
		button3 = false;
		firstOpenMain = false;

	}

	void MenuUpdate()
		{
			if (opening == true) {


			if(options == false)
			{
						if (debug == true) {
								Debug.Log ("Open! Main.");
						}

						if (firstOpenMain == false) {
								button1 = true;
								button2 = false;
								button3 = false;
								firstOpenMain = true;
						}

						if (Input.GetKeyDown ("up")) {
					moved = false;
								if (button1 == true && moved == false) {
										button2 = true;
										button1 = false;
						if (debug == true) {
							Debug.Log ("Moved from 1 to 2.");
						}
						moved = true;
								}

								if (button2 == true && moved == false) {
										button3 = true;
										button2 = false;
						if (debug == true) {
							Debug.Log ("Moved from 2 to 3.");
						}
						moved = true;
								}

								if (button3 == true && moved == false) {
										button1 = true;
										button3 = false;
						if (debug == true) {
							Debug.Log ("Moved from 3 to 1.");
						}
						moved = true;
								}
						}

						if (Input.GetKeyDown ("down")) {
					moved = false;
								if (button1 == true && moved == false) {
										button3 = true;
										button1 = false;
						if (debug == true) {
							Debug.Log ("Moved from 1 to 3.");
						}
						moved = true;
								}
					
								if (button2 == true && moved == false) {
										button1 = true;
										button2 = false;
						if (debug == true) {
							Debug.Log ("Moved from 2 to 1.");
						}
						moved = true;
								}
					
								if (button3 == true && moved == false) {
										button2 = true;
										button3 = false;
						if (debug == true) {
							Debug.Log ("Moved from 3 to 2.");
						}
						moved = true;
								}
						}

						if (Input.GetKeyDown ("u")) {
								if (button1 == true) {
									//call kill method
									closeMenu();
								}
				
								if (button2 == true) {
										//load another part of the menu
					options = true;
								}
				
								if (button3 == true) {
											//Quit
						if (debug == true) {
							Debug.Log ("Quiting.");
						}
										opening = false;
										options = false;
										button1 = false;
										button2 = false;
										button3 = false;
										firstOpenMain = false;
					if(Application.loadedLevel == 0)
										{
							Debug.Log("The application died.");
							opening = false;
							options = false;
							button1 = false;
							button2 = false;
							button3 = false;
							firstOpenMain = false;
							Application.Quit();
										}
					else{
							Debug.Log("The application moved to menu.");
							Application.LoadLevel(moveTo);
					}
								}
						}

				} else if(options == true) {

				if (debug == true) {
					Debug.Log ("Open! Options.");
				}
				
				if (firstOpenMain == false) {
					button1 = true;
					button2 = false;
					button3 = false;
					firstOpenMain = true;
				}
				
				if (Input.GetKeyDown ("up")) {
					moved = false;
					if (button1 == true && moved == false) {
						button2 = true;
						button1 = false;
						if (debug == true) {
							Debug.Log ("Moved from 1 to 2.");
						}
						moved = true;
					}
					
					if (button2 == true && moved == false) {
						button3 = true;
						button2 = false;
						if (debug == true) {
							Debug.Log ("Moved from 2 to 3.");
						}
						moved = true;
					}
					
					if (button3 == true && moved == false) {
						button1 = true;
						button3 = false;
						if (debug == true) {
							Debug.Log ("Moved from 3 to 1.");
						}
						moved = true;
					}
				}
				
				if (Input.GetKeyDown ("down")) {
					moved = false;
					if (button1 == true && moved == false) {
						button3 = true;
						button1 = false;
						if (debug == true) {
							Debug.Log ("Moved from 1 to 3.");
						}
						moved = true;
					}
					
					if (button2 == true && moved == false) {
						button1 = true;
						button2 = false;
						if (debug == true) {
							Debug.Log ("Moved from 2 to 1.");
						}
						moved = true;
					}
					
					if (button3 == true && moved == false) {
						button2 = true;
						button3 = false;
						if (debug == true) {
							Debug.Log ("Moved from 3 to 2.");
						}
						moved = true;
					}
				}

				if (Input.GetKeyDown ("u")) {
					if (button1 == true) {
						options = false; //move back to main menu
						if (debug == true) {
							Debug.Log ("Moving to main.");
						}
					}
					
					if (button2 == true) {
						soundOn = !soundOn;
						if (debug == true) {
							Debug.Log ("Sound switched.");
						}
					}
					
					if (button3 == true) {
						soundEffectsOn = !soundEffectsOn;
						if (debug == true) {
							Debug.Log ("Sound effects switched.");
						}
					}
				}

			}


		}			else { //closed
			if(debug == true)
			{
			Debug.Log("Closed");
			}
		}
	}

		}
