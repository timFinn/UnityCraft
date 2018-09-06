using UnityEngine;
using System.Collections;

public class SpawnFood : MonoBehaviour
{

    public GameObject parent;
    public GameObject foodPrefab;

    private Quaternion foodDirection;

    // Use this for initialization
    void Start()
    {
        parent = GameObject.FindGameObjectWithTag("foodSpwn");
        foodDirection = parent.transform.rotation;
        InvokeRepeating("newFood", 3.0f, 20.0f);

    }

    void newFood()
    {
        Instantiate(foodPrefab, transform.position, foodDirection);
    }
}