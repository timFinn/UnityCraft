using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PickUpItem : MonoBehaviour
{
    public GameObject player;
    public GameObject ship;
    public int woodCount;
    public int gemCount;

    private Text woodText;
    private Text gemText;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        woodText = GameObject.Find("WoodText").GetComponent<Text>();
        gemText = GameObject.Find("GemText").GetComponent<Text>();
        woodCount = 0;
        gemCount = 0;
        UpdateText(woodText, woodCount);
        UpdateText(gemText, gemCount);
    }

    void Update()
    {
        if(woodCount == 20 && gemCount == 5)
        {
            GameObject.Instantiate(ship, transform);
            Animator anim = ship.GetComponent<Animator>();
            anim.Play("PirateShip_sailaway");
            //game ends. load credits
            SceneManager.LoadScene("Credits Scene");
            Debug.Log("Win");
        }
    }

    void OnTriggerEnter(Collider col)
    {

        //Debug.Log("Pickup trigger");
        if (col.gameObject.tag == "wood")
        {
            col.gameObject.SetActive(false);
            woodCount++;
            UpdateText(woodText, woodCount);
            Debug.Log(woodCount);
        }
        else if (col.gameObject.tag == "gem")
        {
            col.gameObject.SetActive(false);
            gemCount++;
            UpdateText(gemText, gemCount);
            Debug.Log(gemCount);
        }
    }

    void UpdateText(Text txt, int count)
    {
        txt.text = count.ToString();
    }
}
