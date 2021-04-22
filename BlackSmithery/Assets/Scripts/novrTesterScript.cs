using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class novrTesterScript : MonoBehaviour
{
    public GameObject thePlayerHead;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = new Vector3(thePlayerHead.transform.position.x, transform.position.y, thePlayerHead.transform.position.z);
        transform.position = pos;
    }
}
