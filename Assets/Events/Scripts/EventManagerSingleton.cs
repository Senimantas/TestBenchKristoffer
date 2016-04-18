using UnityEngine;
using System.Collections;

public class EventManagerSingleton
{
	private static EventManagerSingleton _instance = null;

	// Get the instance of the EventManagerSingleton
	public static EventManagerSingleton instance
	{
		// This ensures that the instance can only be gotten, never set from the outside the class
		get
		{
			// If the instance does not yet exist, then create one
			if (_instance == null)
				_instance = new EventManagerSingleton();
			return _instance;
		}
	}

	// OnClick event handle
	public delegate void ClickAction();
	public event ClickAction OnClicked;

	// Private constructor to prevent initialization from outside the class
	private EventManagerSingleton () {}
}
