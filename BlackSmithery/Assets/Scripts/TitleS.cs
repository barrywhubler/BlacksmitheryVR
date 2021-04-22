using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleS : MonoBehaviour
{
    public Light deLight;
    //public GameObject TitlePanel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = gameObject.transform.eulerAngles;
        rot = new Vector3(rot.x, rot.y += 0.15f, rot.z);
        gameObject.transform.eulerAngles = rot;
        deLight.transform.eulerAngles = -rot;

        if (OVRInput.GetDown(OVRInput.Button.One) || OVRInput.GetDown(OVRInput.Button.Two) || OVRInput.GetDown(OVRInput.Button.Three) || OVRInput.GetDown(OVRInput.Button.Four) || OVRInput.GetDown(OVRInput.Button.Start) || Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(1);
        }
    }
}
