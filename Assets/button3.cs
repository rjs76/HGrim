﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player2"))
        {

            DestroyObjects();
        }
    }

    public void DestroyObjects()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("destroy3");
        foreach (GameObject target in gameObjects)
        {
           // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            GameObject.Destroy(target);
        }
    }
}