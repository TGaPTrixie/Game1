using UnityEngine;
using System.Collections;

public class DetectClicks : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonUp (0)) 
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

			RaycastHit hit;

			if(Physics.Raycast (ray,out hit))
			{
				hit.collider.SendMessage ("Touched",SendMessageOptions.DontRequireReceiver);
			}
		}
	}
}
