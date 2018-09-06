using UnityEngine;
using System.Collections;

public class Modify : MonoBehaviour
{    
    public GameObject woodPrefab;
    Vector2 rot;

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, 100))
            {
                EditTerrain.SetBlock(hit, new BlockAir());
                GameObject.Instantiate(woodPrefab, hit.collider.transform);
            }
        }
    }
}