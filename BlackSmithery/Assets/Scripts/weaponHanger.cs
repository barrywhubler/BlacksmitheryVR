using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponHanger : MonoBehaviour
{
    public GameObject weaponSpot;
    private GameObject blade;
    private bool attaching = false;
    public GameObject gmgo;

    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Weapon")
        {
            blade = other.gameObject;
            blade.GetComponent<OVRGrabbable>().enabled = false;
            
            attaching = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (attaching)
        {
            blade.transform.position = Vector3.Lerp(blade.transform.position, weaponSpot.transform.position, 10 * Time.deltaTime);

            float dist = Vector3.Distance(blade.transform.position, weaponSpot.transform.position);
            if (dist < 0.1f)
            {
                blade.transform.position = weaponSpot.transform.position;
                blade.transform.eulerAngles = weaponSpot.transform.eulerAngles;
                attaching = false;
                blade.GetComponent<OVRGrabbable>().enabled = true;
                gmgo.GetComponent<GameManager>().isWon = true;
            }
        }


    }
}