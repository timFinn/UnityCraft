using UnityEngine;
using System.Collections;

public class SpawnWood : MonoBehaviour
{

    public GameObject parent;
    public GameObject woodPrefab;

    private Quaternion itemDirection;

    // Use this for initialization
    void Start()
    {
        parent = GameObject.FindGameObjectWithTag("woodSpwn");
        itemDirection = parent.transform.rotation;
        InvokeRepeating("newItem", 3.0f, 2.0f);

    }

    void newItem()
    {
        Instantiate(woodPrefab, transform.position, itemDirection);
    }
}