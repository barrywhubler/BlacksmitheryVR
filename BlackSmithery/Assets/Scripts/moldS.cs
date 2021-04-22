using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moldS : MonoBehaviour
{
    public ParticleSystem particleDust;
    public GameObject weaponSpawn;
    public GameObject weaponPart;
    public bool isMolded = false;
    private void OnTriggerEnter(Collider other)
    {
        print("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^" + other.name + other.tag);
        if (other.name == "hitter" && isMolded)
        {
            particleDust.Play();
            particleDust.transform.SetParent(null);
            Invoke("BreakMold", 3);
        }
        if (other.tag == "Molten" && isMolded == false)
        {
            print("888888888888888888888888888888888888888888888888888888888888888");
            //Instantiate(weaponPart);
            //weaponPart.transform.position = weaponSpawn.transform.position;
            //weaponPart.transform.eulerAngles = weaponSpawn.transform.eulerAngles;
            isMolded = true;
        }

    }
    private void OnTriggerExit(Collider other)
    {

    }
    public void BreakMold()
    {
        Instantiate(weaponPart);
        weaponPart.transform.position = weaponSpawn.transform.position;
        weaponPart.transform.eulerAngles = weaponSpawn.transform.eulerAngles;
        Destroy(gameObject);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
