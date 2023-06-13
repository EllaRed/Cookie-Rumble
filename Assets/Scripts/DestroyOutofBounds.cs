using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    float topBounds=35;
    float lowerBound=-12;
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z>topBounds)
        {
            Destroy(gameObject);
        }else if (transform.position.z< lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
