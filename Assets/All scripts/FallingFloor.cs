using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingFloor : MonoBehaviour {
    Rigidbody2D rgb;

	// Use this for initialization
	void Start () {
        rgb = GetComponent<Rigidbody2D>();
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals ("Player"))
        {
            Invoke("Fall2", 0.5f);
            Destroy(gameObject, 1f);
        }
    }

    void DropPlatform()
    {
        rgb.isKinematic = false;
    }

}
