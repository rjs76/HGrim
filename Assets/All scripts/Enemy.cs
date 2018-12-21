using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float time;
    public int type;
    private Rigidbody2D rb2d;
    public int speed;
    public Animator animator;
    public float actnumber;

	// Use this for initialization
	void Start () {
		 time = 0f;
	}
	
	// Update is called once per frame
	void Update () {
       
        time += Time.deltaTime;
        if (time >= 2f)      //time between actions
        {   //After delay, do action
            //Random number gen
            float state = Random.value * 100;     //for 0-100%
            if (state < 20)     //30% chance
            {
                StartCoroutine(StartAction1());
            }
            else if (state < 40) //25% chance
            {
                StartCoroutine(StartAction2());
            }
            else if (state < 60) //25% chance
            {
                StartCoroutine(StartAction3());
            }
            else if (state < 80) //25% chance
            {
                StartCoroutine(StartAction3());
            }
            else    //45% chance
            {
                StartCoroutine(StartAction5());
            }
            time = 0.0f;
        }
    }

    IEnumerator StartAction1()
    {
        animator.SetInteger("Action", 1);
        yield return new WaitForSeconds(1.5f);
        animator.SetFloat("Action", 0);
    }

    IEnumerator StartAction2()
    {
        animator.SetInteger("Action", 2);
        yield return new WaitForSeconds(1.5f);
        animator.SetInteger("Action", 0);
    }

    IEnumerator StartAction3()
    {
        animator.SetInteger("Action", 3);
        yield return new WaitForSeconds(1.5f);
        animator.SetInteger("Action", 0);
    }

    IEnumerator StartAction4()
    {
        animator.SetInteger("Action", 4);
        yield return new WaitForSeconds(1.5f);
        animator.SetInteger("Action", 0);
    }

    IEnumerator StartAction5()
    {
        animator.SetInteger("Action", 5);
        yield return new WaitForSeconds(1.5f);
        animator.SetInteger("Action", 0);
    }
}
