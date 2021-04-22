using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickS : MonoBehaviour
{
    public ParticleSystem particleSparks;
    public float pickPower = 1;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Depo"))
        {

            particleSparks.Play();
        }
    }
}
