using UnityEngine;
using System.Collections;

public class LoadLevelOnClick : MonoBehaviour
{
	public string levelName;

	void Touched()
	{
		Application.LoadLevel(levelName);
	}
}
