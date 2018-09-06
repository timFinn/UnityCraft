using UnityEngine;
using System.Collections;

public class SpawnGem : MonoBehaviour
{

    public GameObject parent;
    public GameObject gemPrefab;

    private Quaternion foodDirection;

    // Use this for initialization
    void Start()
    {
        parent = GameObject.FindGameObjectWithTag("gemSpwn");
        foodDirection = parent.transform.rotation;
        InvokeRepeating("newItem", 3.0f, 10.0f);

    }

    void newItem()
    {
        Instantiate(gemPrefab, transform.position, foodDirection);
    }
}