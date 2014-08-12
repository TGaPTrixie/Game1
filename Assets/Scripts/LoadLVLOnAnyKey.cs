﻿using UnityEngine;
using System.Collections;

public class LoadLVLOnAnyKey : MonoBehaviour
{
	public string levelName;
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.anyKeyDown)
		{
			Application.LoadLevel(levelName);
		}
	}
}
