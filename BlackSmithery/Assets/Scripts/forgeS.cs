using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forgeS : MonoBehaviour
{
    public ParticleSystem particleForge;

    private void OnTriggerEnter(Collider other)
    {
        particleForge.Play();
        if(other.tag == ("Crucible")){
            if(GetComponent<crucPock>().isMolten == false)
            {
                GetComponent<crucPock>().isMolten = true;
            }

        }
    }
    private void OnTriggerExit(Collider other)
    {
        particleForge.Stop();
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
