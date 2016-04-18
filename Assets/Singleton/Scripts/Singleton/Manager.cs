using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {

    public static Manager instance = null;

    public int levelNumber = 3;

	// Use this for initialization
	void Awake ()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
	}
}
