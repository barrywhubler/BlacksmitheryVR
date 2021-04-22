using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quenchS : MonoBehaviour
{
    public ParticleSystem particleSteam;
    private bool isWet = false;
    private GameObject hotSword;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "WeaponPart")
        {
            hotSword = other.gameObject;
            if (hotSword.GetComponent<weaponS>().isHot == true)
            {
                isWet = true;
                hotSword.GetComponent<weaponS>().swordWet = true;


                //if (other.GetComponent<>)

                particleSteam.Play();
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "WeaponPart")
        {
            particleSteam.Stop();
            isWet = false;
            hotSword.GetComponent<weaponS>().swordWet = false;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isWet)
        {
            if(hotSword.GetComponent<weaponS>().hotCount > 0)
            {
                hotSword.GetComponent<weaponS>().hotCount--;
                hotSword.GetComponent<weaponS>().attackPlus += 0.1f;


            }
            else
            {
                isWet = false;
                hotSword.GetComponent<weaponS>().swordWet = false;
                hotSword.GetComponent<weaponS>().isHot = false;
                particleSteam.Stop();
            }
        }
    }
}
