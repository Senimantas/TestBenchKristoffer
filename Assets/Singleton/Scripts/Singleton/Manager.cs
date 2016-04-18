using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    public static Manager instance = null;

    public int levelNumber = 3;
	private int gameNumber = 2;

	// Use this for initialization
	void Awake ()
	{
		Debug.Log("Awake");
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
	}

	void Start ()
	{
		Debug.Log("Start");
	}

	void OnEnable ()
	{
		Debug.Log("OnEnable");
	}

	void OnDisable ()
	{
		Debug.Log("OnDisable");
	}

	void OnDestroy ()
	{
		Debug.Log("OnDestroy");
	}
}
