using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AICrocodileMoving : MonoBehaviour
{

    // To move The Crocodile
    public bool IsMoving; // If The Crocodile Have To Move Forwerd And BackWards
    
    bool MoveNow = true;


    public GameObject MovingCrocodile;
    public GameObject felMayaCorcodile;

    GameObject Player;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

     void Update()
    {
        if (MoveNow)
        {
            felMayaCorcodile.GetComponent<Corodile>().Moving(false);
        }
        else
        {
            felMayaCorcodile.GetComponent<Corodile>().Moving(true);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (IsMoving && collision.tag == "Player")
        {
            MoveNow = false;
        }
    }

     void OnTriggerExit2D(Collider2D collision)
    {
        if (IsMoving && collision.tag == "Player")
        {
            MoveNow = true;
        }
    }

}
