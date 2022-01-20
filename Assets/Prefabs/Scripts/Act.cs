using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Act : MonoBehaviour
{
    public GameObject[] firstGroup;
    public Material transparent;

    private void OnTriggerEnter(Collider other)
    {
       
            foreach (GameObject first in firstGroup)
            {
                first.GetComponent<Renderer>().material = transparent;
                first.GetComponent<Collider>().isTrigger = true;

            }

            GetComponent<Renderer>().material = transparent;

        }
    
}