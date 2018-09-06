using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour {

	public float timeBetweenAttacks = 0.5f;
	public int attackDamage = 10;

	bool playerInRange;

	float timer = 0;

	Animator anim;
	GameObject player;
	PlayerDamage playerDamage;
	EnemyDamage enemyDamage;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerDamage = player.GetComponent<PlayerDamage> ();
		enemyDamage = GetComponent<EnemyDamage> ();
		anim = GetComponent<Animator> ();
	}


	void OnTriggerEnter(Collider other){
		if (other.gameObject == player) {
			playerInRange = true;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject == player) {
			playerInRange = false;
		}
	}


	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (timer >= timeBetweenAttacks && playerInRange && enemyDamage.enemyHealth > 0) {
			Attack ();
		}

		if (playerDamage.healthPoints <= 0)
		{
			anim.SetTrigger ("PlayerDead");
			Destroy (player);
		}
	}

	void Attack()
	{
		timer = 0f;

		if (playerDamage.healthPoints > 0) {
			//playerDamage.TakeDamage (attackDamage);
		}
			
	}
}
