using UnityEngine;
using System.Collections;

public class NoOverlap : MonoBehaviour {
    public Rigidbody other;
    private bool overlap;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionStart(Collision col)
    {
        other = col.gameObject.GetComponent<Rigidbody>();
        other.AddForce(30.0f, 0f, 5.0f, ForceMode.Impulse);
    }
}
