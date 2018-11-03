using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SidetoSide : MonoBehaviour {
    float dirX, moveSpeed = 3f;
    bool moveright = true; 
	// Use this for initialization
	void Update () {
        if (transform.position.x > 57f)
            moveright = false;
        if (transform.position.x < 55f)
            moveright = true;

        if (moveright)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }

}
