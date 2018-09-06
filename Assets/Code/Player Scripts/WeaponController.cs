using UnityEngine;
using System.Collections;

public class WeaponController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("enemy collision");
        //if (col.gameObject.tag == "enemy")
        //{
            col.rigidbody.AddForce(transform.forward, ForceMode.Impulse);
        //}
    }
}
