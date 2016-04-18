using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour 
{
	public delegate void ClickEvent();

	public static event ClickEvent OnClicked;
	public static event ClickEvent OnPressed;

	void OnGUI()
	{
		if (GUI.Button (new Rect (Screen.width / 2 - 50, 5, 100, 30), "Click"))
		{
			if (OnClicked != null)
				OnClicked();
		}
	}
}