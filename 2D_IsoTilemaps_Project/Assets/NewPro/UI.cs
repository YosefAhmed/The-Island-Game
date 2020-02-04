using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public void Load(string toload)
	{
		Application.LoadLevel (toload);
	}

	public void Exit()
	{
		Application.Quit();
	}
}
