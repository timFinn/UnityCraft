using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

    public Transform player;
    public float speed;
    static Animator anim;
    private Vector3 moveDirection = Vector3.zero;

    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 direction = player.position - this.transform.position;

        moveDirection = new Vector3(5, 0, 0);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;
        //field of vision
        //float angle = Vector3.Angle (direction, this.transform.forward);

        if (Vector3.Distance(player.position, this.transform.position) < 25)
        {
            direction.y = 0;

            //this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.0f);

            anim.SetBool("isIdle", false);
            if (direction.magnitude > 10)
            {
                this.transform.Translate(0, 0, 0.05f);
                anim.SetBool("isWalking", true);
                anim.SetBool("isAttacking", false);
            }
            else
            {
                anim.SetBool("isAttacking", true);

                anim.SetBool("isWalking", false);
            }
        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
        }
    }
}
