using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerDamage : MonoBehaviour {

	public float healthPoints;

    private Text healthText;
    

	private Animator anim;

	// Use this for initialization
	void Start () {
        healthText = GameObject.Find("HealthText").GetComponent<Text>();
		anim = GetComponent<Animator> ();
	}

	void OnCollisionEnter(Collision col)
	{

		ContactPoint contact = col.contacts[0];
		if (contact.point.y > transform.position.y)
		{
			anim.SetTrigger("hit");
			healthPoints -= 0.25f;
            UpdateText(healthText, healthPoints);
			if (healthPoints <= 0.0f)
			{
				transform.Rotate(0, 180, 0);
				anim.SetTrigger("PlayerDead");
				Destroy(gameObject, 0.5f);
			}
		}
	}

    void UpdateText(Text txt, float count)
    {
        txt.text = count.ToString();
    }
}
