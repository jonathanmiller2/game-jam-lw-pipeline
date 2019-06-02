﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
		gameObject.transform.position = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		Debug.Log(gameObject.transform.position);
	}
}