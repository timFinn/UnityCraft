using UnityEngine;
using System.Collections;

public class FollowMe : MonoBehaviour {
    public GameObject player;
    public GameObject target;
    private Animator anim;
    private Rigidbody rb;
    private int minDist;
    private float speed;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody>();
        minDist = 3;
        speed = 5;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = player.transform.position - this.transform.position;

        float step = speed * Time.deltaTime;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, direction, step, 0.0f);
        Debug.DrawRay(transform.position, newDir, Color.red);

        transform.rotation = Quaternion.LookRotation(newDir);

        if (Vector3.Distance(transform.position, player.transform.position) >= minDist){
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 0.05f);            
        }          

        if (direction.magnitude > 0)
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isIdle", false);
        }
        if (direction.magnitude <= 2.0f)
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isIdle", true);            
        }
        if (Vector3.Distance(transform.position, player.transform.position) < 1.0f)
        {
            anim.Play("Attack");
        }
	}
}
