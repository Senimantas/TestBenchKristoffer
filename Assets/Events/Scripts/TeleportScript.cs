using UnityEngine;
using System.Collections;

public class TeleportScript : MonoBehaviour 
{
	void OnEnable()
	{
		EventManager.OnClicked += Teleport;
//		EventManager.OnClicked += TeleportRed;
	}


	void OnDisable()
	{
		EventManager.OnClicked -= Teleport;
	}


	void Teleport()
	{
		Vector3 pos = transform.position;
		pos.y = Random.Range (1.0f, 3.0f);
		transform.position = pos;
	}

	void TeleportRed(int a)
	{
		Vector3 pos = transform.position;
		pos.y = Random.Range (1.0f, 3.0f);
		transform.position = pos;
	}
}