using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerPointScript : MonoBehaviour
{
    public bool isHammered = false;
    public bool isSharp = false;
    public GameObject mySword;
    private float hammerSize = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SharpenEdge()
    {
        isSharp = true;
    }

    private void OnTriggerEnter(Collider other)
    {

        //print("?????????????????????????????????????????" + name);
        if(other.tag == "Hitter"||other.name == "hitter")
        {
            //print("Hit!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!" + name);

            //hammerSize = other.GetComponent<hammerS>().hammerPower;
            mySword.GetComponent<buildMetal>().Hammered(name, gameObject, hammerSize, isSharp);
           // buildMetal.get
        }
        if(other.tag == "Whet")
        {
            print("***********************************************************");
            mySword.GetComponent<buildMetal>().WhetColor();
        }
    }
    // Update is called once per frame
    void Update()
    {
        //print(gameObject.name);



    }
}
