using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bate555555 : MonoBehaviour
{
    public GameObject WaterCroc;
    public GameObject LandCroc;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "WaterCroc")
        {
            Debug.Log("watercroc balabnablab");
            WaterCroc.SetActive(true);
            LandCroc.SetActive(false);
        }
    }

     void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "WaterCroc" )
        {
            Debug.Log("Water croc badabdabdad");
            WaterCroc.SetActive(false);
            LandCroc.SetActive(true);
            LandCroc.transform.position = gameObject.transform.position;
        }
    }

    
}
