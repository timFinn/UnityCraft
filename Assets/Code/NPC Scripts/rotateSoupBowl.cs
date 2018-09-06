using UnityEngine;
using System.Collections;

public class rotateSoupBowl : MonoBehaviour {
	
	// Update is called once per frame
	void Update () 
	{
		//transform.Rotate (new Vector3 (90, 0, 0) * Time.deltaTime);
		transform.Rotate(Vector3.up, 100f * Time.deltaTime);
	}
}
