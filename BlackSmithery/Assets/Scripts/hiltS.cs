using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hiltS : MonoBehaviour
{
    public GameObject bladeSpot;
    private GameObject blade;
    private bool attaching = false;
    private bool idAttached = false;
    private bool isDone = false;
    public GameObject GaMa;
    public int numberSave = 0;
    public bool isLoved = false;


    // Start is called before the first frame update
    void Start()
    {
        //GaMa = GameObject.Find("GameManager");
        //if (GaMa.GetComponent<GameManager>().SwordOne == null)
        //{
        //    GaMa.GetComponent<GameManager>().SwordOne = gameObject;
        //    numberSave = 1;
        //}
        //else if (GaMa.GetComponent<GameManager>().SwordTwo == null)
        //{
        //    GaMa.GetComponent<GameManager>().SwordTwo = gameObject;
        //    numberSave = 2;
        //}
        //else if (GaMa.GetComponent<GameManager>().SwordThree == null)
        //{
        //    GaMa.GetComponent<GameManager>().SwordThree = gameObject;
        //    numberSave = 3;
        //}
    }

    //public void Refresh()
    //{
    //    if (numberSave == 1)
    //    {
    //        GaMa.GetComponent<GameManager>().SwordOne = gameObject;

    //    }
    //    else if (numberSave == 2)
    //    {
    //        GaMa.GetComponent<GameManager>().SwordTwo = gameObject;

    //    }
    //    else if (numberSave == 3)
    //    {
    //        GaMa.GetComponent<GameManager>().SwordThree = gameObject;

    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "WeaponPart" && isDone == false)
        {
            blade = other.gameObject;
            blade.GetComponent<OVRGrabbable>().enabled = false;
            attaching = true;
        }
        if(other.tag =="CurseBox" && other.gameObject.transform.parent.gameObject.GetComponent<buildMetal>().isHome == false)
        {
            other.gameObject.transform.parent.gameObject.GetComponent<buildMetal>().isHome = true;
            other.gameObject.transform.parent.gameObject.transform.SetParent(transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (attaching)
        {
            blade.transform.position = Vector3.Lerp(blade.transform.position, bladeSpot.transform.position, 10 * Time.deltaTime);

            float dist = Vector3.Distance(blade.transform.position, bladeSpot.transform.position);
            if (dist < .01)
            {
                blade.transform.position = bladeSpot.transform.position;
                blade.transform.eulerAngles = bladeSpot.transform.eulerAngles;
                attaching = false;
                idAttached = true;
            }
        }
        else if (idAttached)
        {
            //blade.transform.eulerAngles = bladeSpot.transform.eulerAngles;
            //blade.transform.SetParent(bladeSpot.transform);

            blade.GetComponent<weaponS>().SelfDestuct(gameObject);
            idAttached = false;
            isDone = true;
        }


    }
}
