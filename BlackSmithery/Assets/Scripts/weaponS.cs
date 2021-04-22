using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponS : MonoBehaviour
{
    public bool isHot = true;
    public int hotCount = 500;
    public float attackPlus = 0f;
    public bool swordWet = false;
    public GameObject GaMan;
    private int saveNumber = 0;
    public GameObject bladeObject;

    private void OnTriggerEnter(Collider other)
    {

    }
    private void OnTriggerExit(Collider other)
    {

    }


    // Start is called before the first frame update
    void Start()
    {
        GaMan = GameObject.Find("GameManager");//FindObjectOfType <GameManager> ();
        if (GaMan.GetComponent<GameManager>().SwordBladeOne == null)
        {
            GaMan.GetComponent<GameManager>().SwordBladeOne = gameObject;
            saveNumber = 1;
        }
        else if (GaMan.GetComponent<GameManager>().SwordBladeTwo == null)
        {
            GaMan.GetComponent<GameManager>().SwordBladeTwo = gameObject;
            saveNumber = 2;
        }
        else if (GaMan.GetComponent<GameManager>().SwordBladeThree == null)
        {
            GaMan.GetComponent<GameManager>().SwordBladeThree = gameObject;
            saveNumber = 3;
        }
    }

    //public void Refresher()
    //{
    //    if(saveNumber == 1)
    //    {
    //        GaMan.GetComponent<GameManager>().SwordBladeOne = gameObject;

    //    }
    //    else if (saveNumber == 2)
    //    {
    //        GaMan.GetComponent<GameManager>().SwordBladeTwo = gameObject;

    //    }
    //    else if (saveNumber == 3)
    //    {
    //        GaMan.GetComponent<GameManager>().SwordBladeThree = gameObject;

    //    }
    //}

    // Update is called once per frame

    public void SelfDestuct(GameObject Attacher)
    {
        bladeObject.transform.SetParent(Attacher.transform);
        bladeObject.GetComponent<buildMetal>().HoldPosition();

        if (saveNumber == 1)
        {
            GaMan.GetComponent<GameManager>().SwordBladeOne = bladeObject;
            bladeObject.GetComponent<buildMetal>().yourID = 1;

        }
        else if (saveNumber == 2)
        {
            GaMan.GetComponent<GameManager>().SwordBladeTwo = bladeObject;
            bladeObject.GetComponent<buildMetal>().yourID = 2;

        }
        else if (saveNumber == 3)
        {
            GaMan.GetComponent<GameManager>().SwordBladeThree = bladeObject;
            bladeObject.GetComponent<buildMetal>().yourID = 3;

        }

        Destroy(gameObject);
    }

    void Update()
    {
        if(attackPlus > 0f)
        {
            bladeObject.GetComponent<buildMetal>().swordPoints += attackPlus;

            attackPlus = 0f;
        }
        if(swordWet == true){

        }
        if (GetComponent<OVRGrabbable>().isGrabbed)
        {
            bladeObject.GetComponent<buildMetal>().isHome = true;
        }
    }
}
