using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

public Text text;
private enum States	{
	ship, keyboard, look, button, flight, shield, navigation, drive, sol,
	};

private	States myState;

// Use this for initialization
void Start () {
	myState = States.ship;
}


// Update is called once per frame
void Update () {
	print (myState);
	if (myState == States.ship) 								{ship();}
	else if (myState == States.keyboard) 				{keyboard();}
	else if (myState == States.look) 						{look();}
	else if (myState == States.button) 					{button();}
	else if (myState == States.flight) 					{flight();}
	else if (myState == States.shield) 					{shield();}
	else if (myState == States.navigation) 			{navigation();}
	else if (myState == States.drive) 					{drive();}
	else if (myState == States.sol) 						{sol();}
}

#region State handler methods

void ship() {
	text.text = "You wake up feeling groggy and distorted, waking up in zero gravity really messed with " +
							"your orientation and you wonder for a few second where you are. The familiar sound of  " +
							"the humming engine quickly remind you that you are in classic sidewinder. The last thing " +
							"you remember was exiting hyperspace and the sun hit you dead on with a solar eruption.\n\n" +
							"Press L to Look around";
	if 			(Input.GetKeyDown(KeyCode.L)) 		{myState = States.look;}
}


void look() {
	text.text = "Main holographic displays are not showing so the the cockpit is pretty dark. " +
							"The only illumination are the stars outside and the emergency system " +
							"restart Button behind the spectrum Keyboard.";
  if 			(Input.GetKeyDown(KeyCode.B)) 		{myState = States.button;}
	else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.keyboard;}
}


void button() {
	text.text = "You push the restart Button multiple times but the holographic displays doesn't restart.\n\n" +
							"Press L to Look around";
  if (Input.GetKeyDown(KeyCode.L)) 					{myState = States.look;}
	else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.keyboard;}
}


void keyboard() {
	text.text = "You look at the spectrum keyboard and remember the lecture your grandfather always held. " +
							"- Every pilot should know the emergency Flight book by heart and the coordinates back to " +
							"SOL and not trust these fancy holographics. ";
  if (Input.GetKeyDown(KeyCode.F)) 					{myState = States.flight;}
	else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.keyboard;}
}

void flight() {
	text.text = "You reach for the emergency Flight book and quickly see the page markers you attached " +
							"during flight training so many years ago. Most of them are unreadable but you can make " +
							"out some of them with the letters. S and N";
  if (Input.GetKeyDown(KeyCode.L)) 					{myState = States.look;}
	else if (Input.GetKeyDown(KeyCode.S)) 		{myState = States.shield;}
	else if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.navigation;}
}

void shield() {
	text.text = "As you fold to the page with the S marker page 212 Shield management. " +
							"You quickly read through the page and punch in the commands on the spectrum Keyboard to " +
							"restart shields module. ";
  if (Input.GetKeyDown(KeyCode.L)) 					{myState = States.look;}
	else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.keyboard;}
	else if (Input.GetKeyDown(KeyCode.N)) 		{myState = States.navigation;}
}

void navigation() {
	text.text = "As you fold to the page with the N marker it takes you to page 23 Navigation management. " +
							"Your happy that your grandfather told you to always remember SOL coordinates. You punch  " +
							"in the commands and coordinates on the spectrum Keyboard to SOL.\n" +
							"Now you just need to find the page that talks about frameshift Drive.";
  if (Input.GetKeyDown(KeyCode.L)) 					{myState = States.look;}
	else if (Input.GetKeyDown(KeyCode.K)) 		{myState = States.keyboard;}
	else if (Input.GetKeyDown(KeyCode.D)) 		{myState = States.drive;}
}

void drive() {
	text.text = "You open page 121 frameshift Drive and start to punch in the commands on the spectrum " +
							"Keyboard and push the SPACE key.";
  if (Input.GetKeyDown(KeyCode.L)) 							{myState = States.look;}
	else if (Input.GetKeyDown(KeyCode.K)) 				{myState = States.keyboard;}
	else if (Input.GetKeyDown(KeyCode.N)) 				{myState = States.navigation;}
	else if (Input.GetKeyDown(KeyCode.Space)) 		{myState = States.sol;}
}

void sol() {
	text.text = "The sidewinder emergency autopilot kicks in and starts to align your ship towards a " +
							"little yellow star in the far far distance. Thrusters kicks of and you start to " +
							"accelerate and as you hit critical speed the hyperdrive kicks in and BOOM you are on " +
							"your way to SOL and civilised space..";
  if (Input.GetKeyDown(KeyCode.L)) 					{myState = States.look;}
}


#endregion
}
