using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oreSpawner : MonoBehaviour
{
    public Transform spawnerPoint;
    public GameObject oreSpawn;


    public void CallSpawn()
    {
        Instantiate(oreSpawn, spawnerPoint);
    }


}
