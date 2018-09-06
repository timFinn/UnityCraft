using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public GameObject player;
    public GameObject parent;
	public float speed;
	public float jumpSpeed;
	public float gravity = 50.0F;

	private Vector2 dir;
	private Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
		speed = 10.0f;
		jumpSpeed = 10.0F;
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController controller = parent.GetComponent<CharacterController>();
			
		if (controller.velocity.magnitude > 0) {
			anim.SetBool ("isWalking", true);
		}
        if (controller.velocity.magnitude == 0) {
            anim.SetBool ("isWalking", false);
        } else {
            anim.SetTrigger ("isWalking");
        }

		if (Input.GetMouseButtonDown (0)) {
			anim.Play ("CutlassAttack2");
            AudioSource a = GetComponent<AudioSource>();
            a.Play();
			BasicAttack ();
		}

        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("isWalking", true);
            BasicAttack();
        }
		if (Input.GetKeyDown (KeyCode.E)) {
			//Interact with the game
			//This will include picking up objects, interacting with NPCs, etc.
			//Basically a do-all button for anything that isn't an attack
		}
	}

    void BasicAttack()
    {

        //RaycastHit hit;
        //Physics.Raycast(transform.position, transform.forward, out hit, 50);
        //hit.rigidbody.AddForce(transform.forward, ForceMode.Impulse);
    }
}
