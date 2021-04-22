using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crucPock : MonoBehaviour
{
    private bool isLoading = false;
    private bool isLoadedIn = false;
    public bool isMolten = false;
    public Transform topp;
    public Transform bottomm;
    public GameObject moltenPint;
    public Light moltenLight;

    private Vector3 orePos;
    private Collider tempOther;
    private GameObject tempGameObject;

    //public GameObject cruc;

    //public GameObject[] contents;






    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == ("Ore"))
        {
            isLoading = true;
            other.GetComponent<OVRGrabbable>().enabled = false;
            tempGameObject = other.gameObject;
            other.GetComponent<Rigidbody>().isKinematic = true;
            //print("11111111111111111111111111111111111111111111111111111111111111111111111111111111");
        }
        if (other.tag == ("Forge"))
        {
            if (isLoadedIn == true)
            {
                isMolten = true;
                Destroy(tempGameObject);
            }
        }
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





        if (topp.transform.position.y < bottomm.transform.position.y && isMolten)
        {
            Instantiate(moltenPint);
            moltenPint.transform.position = topp.transform.position;
            moltenPint.transform.SetParent(null);
            moltenPint.transform.eulerAngles = new Vector3(0f, 0f, 0f);
            isMolten = false;
            isLoadedIn = false;
        }
        if (isLoading == true)
        {
            //orePos = new Vector3;
            orePos = (tempGameObject.transform.position);
            orePos = Vector3.Lerp(orePos, gameObject.transform.position, 10 * Time.deltaTime);
            tempGameObject.transform.position = orePos;

            float dist = Vector3.Distance(tempGameObject.transform.position, transform.position);

            if (dist < 0.05f)
            {
                tempGameObject.transform.SetParent(gameObject.transform);
                isLoading = false;
                isLoadedIn = true;
            }
        }
        if (isMolten)
        {
            moltenLight.enabled = true;
        }
        else
        {
            moltenLight.enabled = false;
        }
        
    }
}
