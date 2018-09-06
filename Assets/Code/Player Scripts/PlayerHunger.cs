using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHunger : MonoBehaviour {

    public int hungerPoints;
    private Text hungerText;

	// Use this for initialization
	void Start () {
        CharacterController controller = GetComponent<CharacterController>();
        hungerText = GameObject.Find("HungerText").GetComponent<Text>();
        hungerPoints = 20;
        InvokeRepeating("Hunger", 1.0f, 20.0f);
        UpdateText(hungerText, hungerPoints);
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider col)
    {        
        if (col.gameObject.tag == "food")
        {
            Destroy(col.gameObject, 0.5f);
            if (hungerPoints < 20)
            {
                hungerPoints++;
                UpdateText(hungerText, hungerPoints);
                Debug.Log("Yum");
            }
        }
    }

    void Hunger()
    {
        hungerPoints--;
        UpdateText(hungerText, hungerPoints);
        if (hungerPoints < 0)
        {
            Debug.Log("Starving");
        }
    }

    void UpdateText(Text txt, int count)
    {
        txt.text = count.ToString();
    }
}
