//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ZoomCon : MonoBehaviour
//{
//    public GameObject MainCam;

//    void OnTriggerStay2D(Collider2D other)
//    {
//        if (other.tag == "Player")
//        {
//            Debug.Log("IN");
//            MainCam.GetComponent<BasicCameraFollow>().ZoomOut();
//            MainCam.GetComponent<BasicCameraFollow>().isZoomed = false;
//        }
//    }

//    void OnTriggerExit2D(Collider2D other)
//    {
//        if (other.tag == "Player")
//        {
//            MainCam.GetComponent<BasicCameraFollow>().isZoomed = true;
//        }
//    }

//}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCon : MonoBehaviour
{
    public GameObject MainCam;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            MainCam.GetComponent<BasicCameraFollow>().ZoomIn();
            MainCam.GetComponent<BasicCameraFollow>().isZoomed = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            MainCam.GetComponent<BasicCameraFollow>().isZoomed = false;
        }
    }

}
