using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crucibleS : MonoBehaviour
{

    private bool isHeld = false;
    private bool isGoingHome = false;

    public GameObject crucPlace;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<OVRGrabbable>().isGrabbed)
        {
            isHeld = true;
        }
        else if (gameObject.GetComponent<OVRGrabbable>().isGrabbed == false)
        {
            if (isHeld)
            {
                isHeld = false;
                isGoingHome = true;

            }
            if (isGoingHome)
            {

                transform.position = Vector3.Lerp(transform.position, crucPlace.transform.position, 3 * Time.deltaTime);
                transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, crucPlace.transform.eulerAngles, 3 * Time.deltaTime);

                float dist = Vector3.Distance(crucPlace.transform.position, transform.position);
                if (dist < .01)
                {
                    transform.position = crucPlace.transform.position;
                    transform.eulerAngles = crucPlace.transform.eulerAngles;
                    isGoingHome = false;
                }


            }
        }
    }
}
