using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class passwordOpen : MonoBehaviour {

	private Animator anim;
	public string curPassword = "35296";
	public string input;
	public bool onTrigger;
	public bool doorOpen;
	public bool keypadScreen;
	public bool help;

	void Start(){
		anim = GetComponent<Animator>();
		doorOpen = false;
	}

	void OnTriggerEnter(Collider other)
	{
		onTrigger = true;
	}

	void OnTriggerExit(Collider other)
	{
		onTrigger = false;
		keypadScreen = false;
		input = "";
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	void Update()
	{

		if(input == curPassword)
		{
			doorOpen = true;
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
			anim.SetBool("toOpen",doorOpen);
			Invoke("SceneUpdate", 4);

		}
	}

	void SceneUpdate()
	{
		SceneManager.LoadScene("Ending");
	}

	void OnGUI()
	{


		if(!doorOpen)
		{
			if(!keypadScreen && onTrigger)
			{
				GUI.skin.box.fontSize = 21;
				GUI.Box(new Rect(100, 0, (200*3/2), (25*3/2)), "Click to open keypad");

				if(Input.GetMouseButtonDown(0))
				{
					keypadScreen = true;
					//onTrigger = false;
					Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
				}

			}

			if(keypadScreen)
			{
				if(help){
					GUI.skin.box.fontSize = 21;
					GUI.Box(new Rect(100, 0, (200*3/2), (25*3/2)), "Enter a 5 digit password");
				}
				GUI.skin.box.fontSize = 58;
				GUI.Box(new Rect((Screen.width/2)-240, (Screen.height/2)-350, 477, (505*4/3+35)), "");
				GUI.Box(new Rect(Screen.width/2-(465/2), (Screen.height/2)-345, 462, 75), input);

				if(GUI.Button(new Rect(Screen.width/2-(465/2), (Screen.height/2)-265, 150, 150), "1"))
				{
					input = input + "1";
					help = false;
				}

				if(GUI.Button(new Rect((Screen.width/2-(465/2)+155), (Screen.height/2)-265, 150, 150), "2"))
				{
					input = input + "2";
					help = false;
				}

				if(GUI.Button(new Rect((Screen.width/2-(465/2)+(2*(150+5))), (Screen.height/2)-265, 150, 150), "3"))
				{
					input = input + "3";
					help = false;
				}

				if(GUI.Button(new Rect((Screen.width/2-(465/2)), (Screen.height/2)-110, 150, 150), "4"))
				{
					input = input + "4";
					help = false;
				}

				if(GUI.Button(new Rect((Screen.width/2-(465/2)+155), (Screen.height/2)-110, 150, 150), "5"))
				{
					input = input + "5";
					help = false;
				}

				if(GUI.Button(new Rect((Screen.width/2-(465/2)+(2*(150+5))), (Screen.height/2)-110, 150, 150), "6"))
				{
					input = input + "6";
					help = false;
				}

				if(GUI.Button(new Rect((Screen.width/2-(465/2)), (Screen.height/2)+45, 150, 150), "7"))
				{
					input = input + "7";
					help = false;
				}

				if(GUI.Button(new Rect((Screen.width/2-(465/2)+155), (Screen.height/2)+45, 150, 150), "8"))
				{
					input = input + "8";
					help = false;
				}

				if(GUI.Button(new Rect((Screen.width/2-(465/2)+(2*(150+5))), (Screen.height/2)+45, 150, 150), "9"))
				{
					input = input + "9";
					help = false;
				}

				if(GUI.Button(new Rect((Screen.width/2-(465/2)+155), (Screen.height/2)+200, 150, 150), "0"))
				{
					input = input + "0";
					help = false;
				}
				if(GUI.Button(new Rect((Screen.width/2-(465/2)),(Screen.height/2)+200,150,150), "X"))
				{
					input = "";
					keypadScreen = false;
					Cursor.lockState = CursorLockMode.Locked;
					Cursor.visible = false;
				}
				if(GUI.Button(new Rect((Screen.width/2-(465/2)+(2*(150+5))),(Screen.height/2)+200,150,150), "?"))
				{
					help = true;

				}
			}

			// if(keypadScreen)
			// {
			// 	if(help){
			// 		GUI.skin.box.fontSize = 14;
			// 		GUI.Box(new Rect(100, 0, 200, 25), "Enter a 5 digit password");
			// 	}
			// 	GUI.skin.box.fontSize = 58;
			// 	GUI.Box(new Rect((Screen.width/2)-160, 80, 320, 505), "");
			// 	GUI.Box(new Rect(Screen.width/2-155, 85, 310, 75), input);
			//
			// 	if(GUI.Button(new Rect(Screen.width/2-155, 165, 100, 100), "1"))
			// 	{
			// 		input = input + "1";
			// 		help = false;
			// 	}
			//
			// 	if(GUI.Button(new Rect(Screen.width/2-50, 165, 100, 100), "2"))
			// 	{
			// 		input = input + "2";
			// 		help = false;
			// 	}
			//
			// 	if(GUI.Button(new Rect(Screen.width/2+55, 165, 100, 100), "3"))
			// 	{
			// 		input = input + "3";
			// 		help = false;
			// 	}
			//
			// 	if(GUI.Button(new Rect(Screen.width/2-155, 270, 100, 100), "4"))
			// 	{
			// 		input = input + "4";
			// 		help = false;
			// 	}
			//
			// 	if(GUI.Button(new Rect(Screen.width/2-50, 270, 100, 100), "5"))
			// 	{
			// 		input = input + "5";
			// 		help = false;
			// 	}
			//
			// 	if(GUI.Button(new Rect(Screen.width/2+55, 270, 100, 100), "6"))
			// 	{
			// 		input = input + "6";
			// 		help = false;
			// 	}
			//
			// 	if(GUI.Button(new Rect(Screen.width/2-155, 375, 100, 100), "7"))
			// 	{
			// 		input = input + "7";
			// 		help = false;
			// 	}
			//
			// 	if(GUI.Button(new Rect(Screen.width/2-50, 375, 100, 100), "8"))
			// 	{
			// 		input = input + "8";
			// 		help = false;
			// 	}
			//
			// 	if(GUI.Button(new Rect(Screen.width/2+55, 375, 100, 100), "9"))
			// 	{
			// 		input = input + "9";
			// 		help = false;
			// 	}
			//
			// 	if(GUI.Button(new Rect(Screen.width/2-50, 480, 100, 100), "0"))
			// 	{
			// 		input = input + "0";
			// 		help = false;
			// 	}
			// 	if(GUI.Button(new Rect(Screen.width/2-155,480,100,100), "X"))
			// 	{
			// 		input = "";
			// 		keypadScreen = false;
			// 		Cursor.lockState = CursorLockMode.Locked;
			// 		Cursor.visible = false;
			// 	}
			// 	if(GUI.Button(new Rect(Screen.width/2+55,480,100,100), "?"))
			// 	{
			// 		help = true;
			//
			// 	}
			// }
		}
	}
}
