﻿//using System.Collections;
//using System.Collections.Generic;
/*
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class ShadowEffect : MonoBehaviour
{
    public Vector3 Offset = new Vector3(-0.1f, -0.1f);
    public Material Material;
    
    GameObject _shadow;

    // Use this for initialization

    void Start ()
    {
        _shadow = new GameObject ("Shadow");
        _shadow.transform.parent = transform;
         
        _shadow.transform.localPosition = Offset;
        _shadow.transform.localPosition = Quaternion.identity;

        SpriteRenderer renderer = GetComponent <SpriteRenderer> ();
        SpriteRenderer sr = _shadow.AddComponent <SpriteRenderer> ();
        sr.sprite = renderer.sprite;
        sr.material = Material;

        //Make sure that shadow is always rendered behind the object
        sr.sortingLayerName = renderer.sortingLayerName;
        sr.sortingOrder = renderer.sortingOrder - 1;

	}
	
	// Update is called once per frame
	void LateUpdate () {
        _shadow.transform.localPosition = Offset;
	}
}
*/