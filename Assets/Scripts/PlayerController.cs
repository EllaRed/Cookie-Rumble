using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float horizontalInput;
    [SerializeField]
    private float speed=10f;
    [SerializeField]
    private float xBounds=12f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( transform.position.x < -xBounds)
        {
            transform.position =new Vector3(-xBounds,transform.position.y,transform.position.z);
        }
        if (transform.position.x > xBounds)
        {
            transform.position =new Vector3(xBounds,transform.position.y,transform.position.z);
        }
        horizontalInput= Input.GetAxis("Horizontal");
        transform.Translate(horizontalInput*Time.deltaTime*speed* Vector3.right);
        
        
    }
}
