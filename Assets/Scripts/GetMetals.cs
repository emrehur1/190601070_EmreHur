using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetMetals : MonoBehaviour
{
   
    public GameObject StashedMetalSpawnArea;

    void Start()
    {
        
    }

    void OnTriggerStay(Collider other)
    {



        if (other.gameObject.tag == "GetMetal")
        {
            StashedMetalSpawnArea.SetActive(true);

        }


    }


    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "GetMetal")
        {
            StashedMetalSpawnArea.SetActive(false);
        }
        


    }


    void Update()
    {
        
    }
}
