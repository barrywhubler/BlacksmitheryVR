using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    public float moveSpeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime;
        pos.y += moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime;
        transform.position = pos;
    }
}
