using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Holder : MonoBehaviour
{
	GameObject Player;
	// GameObjects 
	public GameObject Wood1;
	public GameObject Wood2;
	public GameObject Wood3;
	public GameObject Wood4;
	public GameObject Wood5;
	public GameObject Axe;
	public GameObject[] Fishs;
	public GameObject FishCatcher;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
