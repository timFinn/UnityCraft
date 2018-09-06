using UnityEngine;
using System.Collections;

public class TossCoconut : MonoBehaviour {

    public Rigidbody grenadePrefab;
    public Transform shotPos;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.G))
        {
            Rigidbody shot = Instantiate(grenadePrefab, shotPos.position, shotPos.rotation) as Rigidbody;
            shot.AddForce(transform.forward * 3000f);
        }
	}
}
