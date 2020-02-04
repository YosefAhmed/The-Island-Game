using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corodile : MonoBehaviour
{

    public float movingspeed;

    public bool toplayer = false;

    Transform org;

    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        org = gameObject.transform;
        Player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        if (toplayer)
        {
            transform.position = Vector2.MoveTowards(transform.position, Player.GetComponent<Transform>().position, movingspeed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, org.position, movingspeed * Time.deltaTime);

        }
    }

    public void Moving(bool y)
    {
        toplayer = y;
    }
}
