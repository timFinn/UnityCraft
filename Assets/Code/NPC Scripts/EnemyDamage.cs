using UnityEngine;
using System.Collections;

public class EnemyDamage : MonoBehaviour
{

    private Animator anim;
    public float enemyHealth;
    public GameObject enemyRagdoll;


    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
        enemyHealth = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        //Debug.Log("enemy collision");
        if (col.gameObject.tag == "playerWeapon")
        {
            Debug.Log("enemy damage");
            enemyHealth -= 1.0f;
            //enemyHitCount++;
            if (enemyHealth <= 0.0f)
            {
                //anim.SetTrigger("isDead");
                Destroy(gameObject, 0.5f);
                GameObject instance = (GameObject)Instantiate(enemyRagdoll, transform.position, transform.rotation);
                instance.name = "skull";
                
            }
        }
    }
}
