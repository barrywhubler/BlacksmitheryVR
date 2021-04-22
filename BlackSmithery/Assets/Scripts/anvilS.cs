using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anvilS : MonoBehaviour
{
    //public GameObject swordSpot;
    //private GameObject blade;
    //private int sinceTouchCounter = 0;
    //private bool attaching;
        //private bool isHeld = false;
    //private bool isGoingHome = false;
    

    private void OnTriggerEnter(Collider other)
    {
        //if(other.tag == "WeaponPart")
        //{


            //blade = other.gameObject;
            //if (blade)
            //{
                //attaching = true;
            //}
        //}

    }
    private void OnTriggerExit(Collider other)
    {

    }





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (sinceTouchCounter > 0)
        //{
        //    sinceTouchCounter--;
        //}

        //if (gameObject.GetComponent<OVRGrabbable>().isGrabbed)
        //{
        //    isHeld = true;
        //}
        //else if (blade.GetComponent<OVRGrabbable>().isGrabbed == false && sinceTouchCounter > 0 )
        //{
        //    if (isHeld)
        //    {
        //        isHeld = false;
        //        isGoingHome = true;

        //    }
        //    if (isGoingHome)
        //    {

        //        blade.transform.position = Vector3.Lerp(blade.transform.position, swordSpot.transform.position, 3 * Time.deltaTime);
        //        blade.transform.eulerAngles = Vector3.Lerp(blade.transform.eulerAngles, swordSpot.transform.eulerAngles, 3 * Time.deltaTime);

        //        float dist = Vector3.Distance(swordSpot.transform.position, blade.transform.position);
        //        if (dist < .05)
        //        {
        //            blade.transform.position = swordSpot.transform.position;
        //            blade.transform.eulerAngles = swordSpot.transform.eulerAngles;
        //            isGoingHome = false;
        //        }


        //    }
        //}
    }
}


