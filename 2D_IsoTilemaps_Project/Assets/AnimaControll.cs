using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaControll : MonoBehaviour
{
    Animator animator;
    int currentState;
    List<string> states = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        currentState = 0;

        states.Add("IsIdleS");
        states.Add("IsIdleE");
        states.Add("IsIdleN");
        states.Add("IsIdleW");
        states.Add("IsWalkingS");
        states.Add("IsWalkingE");
        states.Add("IsWalkingN");
        states.Add("IsWalkingNw");
        states.Add("IsWalkingW");
        states.Add("IsWalkingSw");
        Debug.Log(currentState);
    }

    // Update is called once per frame
    void Update()
    {
        /*
         currentState = 0 --> IsIdleS
         currentState = 1 --> IsIdleE
         currentState = 2 --> IsIdleN
         currentState = 3 --> IsIdleW
         currentState = 4 --> IsWalkingS
         currentState = 5 --> IsWalkingE
         currentState = 6 --> IsWalkingN
         currentState = 7 --> IsWalkingNw
         currentState = 8--> IsWalkingW
         currentState = 9 --> IsWalkingSw
         */

        //North
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            animator.SetBool("IsWalkingN", true);
            animator.SetBool(states[currentState], false);
            currentState = states.IndexOf("IsWalkingN");
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("IsIdleN", true);
            animator.SetBool(states[currentState], false);
            currentState = states.IndexOf("IsIdleN");
        }


        //South 
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            animator.SetBool("IsWalkingS", true);
            animator.SetBool(states[currentState], false);
            currentState = states.IndexOf("IsWalkingS");
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            animator.SetBool("IsIdleS", true);
            animator.SetBool(states[currentState], false);
            currentState = states.IndexOf("IsIdleS");
        }

        //East ->
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            animator.SetBool("IsWalkingE", true);
            animator.SetBool(states[currentState], false);
            currentState = states.IndexOf("IsWalkingE");
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("IsIdleE", true);
            animator.SetBool(states[currentState], false);
            currentState = states.IndexOf("IsIdleE");
        }

        //West <-
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (currentState == 0)
            {
                animator.SetBool("IsWalkingSw", true);
                animator.SetBool(states[currentState], false);
                currentState = states.IndexOf("IsWalkingSw");
            }
            else if (currentState == 2)
            {
                animator.SetBool("IsWalkingNw", true);
                animator.SetBool(states[currentState], false);
                currentState = states.IndexOf("IsWalkingNw");
            }
            else
            {
                animator.SetBool("IsWalkingW", true);
                animator.SetBool(states[currentState], false);
                currentState = states.IndexOf("IsWalkingW");
            }
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            animator.SetBool("IsIdleW", true);
            animator.SetBool(states[currentState], false);
            currentState = states.IndexOf("IsIdleW");
        }


    }
}
