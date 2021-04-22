
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hammerS : MonoBehaviour
{
    public ParticleSystem particleSpark;
    public float hammerPower = 1;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "hammerStrike")
        {
            
            particleSpark.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        //particleSpark.Stop();
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
