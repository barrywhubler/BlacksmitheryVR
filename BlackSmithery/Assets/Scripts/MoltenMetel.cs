using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoltenMetel : MonoBehaviour
{
    public GameObject struch;
    public float grow = 0.1f;
    public int counter =0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter++;

        if (counter > 150)
        {
            
            transform.Translate(0, -Time.deltaTime, 0, Space.World);
        }
        else
        {
            struch.transform.localScale += new Vector3(0, grow, 0);
        }
        if (counter > 450)
        {
            Destroy(gameObject);
        }
    }
}
