using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GamePadButton{
	public float Horizontal;
	public float Vertical;
	public bool Y;
	public bool X;
	public bool A;
	public bool B;
}

public class InputManager : SingletonBehaviour<InputManager> {
	public Action<GamePadButton> OnPressButton;

	void Update(){
		if (OnPressButton != null) {
			GamePadButton Gbutton = new GamePadButton ();
			Gbutton.A = Input.GetButton ("Fire2");
			Gbutton.X = Input.GetButton ("Fire1");
			Gbutton.B = Input.GetButton ("Fire3");
			Gbutton.Y = Input.GetButton ("Jump");
			Gbutton.Horizontal = Input.GetAxis ("Horizontal");
			Gbutton.Vertical = Input.GetAxis ("Vertical");
			OnPressButton (Gbutton);
		}
	}
}