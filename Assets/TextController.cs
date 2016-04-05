using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;
	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom}
	private States myState;
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) 			{state_cell();}
		else if (myState == States.sheets_0)	{state_sheets_0();}
		else if (myState == States.lock_0)		{state_lock_0();}
		else if (myState == States.lock_1)		{state_lock_1();}
		else if (myState == States.mirror)		{state_mirror();}
		else if (myState == States.cell_mirror)	{state_cell_mirror();}
		else if (myState == States.freedom)		{state_freedom();}

	}
	
void state_cell () {
		text.text = "You are in a prison cell, and you want to escape. There are " +
				"some dirty sheets on the bed, a mirror on the wall, and the door " +
				"is locked from the outside. \n\n" +
				"Press S to view sheets, M to view Mirror and L to view Lock";
				
	if (Input.GetKeyDown(KeyCode.S))		{myState = States.sheets_0;}
	else if (Input.GetKeyDown(KeyCode.L))	{myState = States.lock_0;}
	else if (Input.GetKeyDown(KeyCode.M))   {myState = States.mirror;}
}

void state_sheets_0 () {
	text.text = "Ewwwww you cannot believe you sleep in those sheets but as you try" +
	 "to clean it you find a paper that contain instructions to open the cell and it says" +
	 "Open the mirror cabinet\n\n" +
		"Press M to go to the mirror";
	
	if (Input.GetKeyDown(KeyCode.R))			{myState = States.cell;}
	if (Input.GetKeyDown(KeyCode.M))			{myState = States.cell_mirror;}
}

void state_lock_0 () {
	text.text = " Are you just going to stare at the lock? Try again and find the clues. \n\n " +
		"Press R to return to roaming your cell";

		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;} 

}

void state_lock_1 (){
	text.text = "YOU ARE OUT OF HERE! SO LONG SUCKERS \n\n" +
	"Press F for freedom, Press R to return to cell (BTW, that's dumb!)";

		if(Input.GetKeyDown(KeyCode.F))		{ myState = States.freedom;}

}

void state_mirror (){ 
	text.text = "Are you just going to stare at yourself? You know that won't unlock the cell....haha \n\n" +
	"Press R to return to roaming your cell";

	if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}

}

void state_cell_mirror (){
	text.text = "YOU GOT THE KEY! Now you have to go to the door and unlock it \n\n" +
	"Press L to go to the lock";

	if (Input.GetKeyDown(KeyCode.L))		{myState = States.lock_1;}
	

}
void state_freedom () {
	text.text = "I AM FREEEEEEEEEEE";
}


}
