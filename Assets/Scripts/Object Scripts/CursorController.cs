﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    public Material[] material;
    public int mat;
    Animator C_Animator;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        mat = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 1f);

        if (Input.GetMouseButtonDown(0))
        {
            foreach (Animator anim in transform.GetComponentsInChildren<Animator>())
            {
                anim.ResetTrigger("Release");
                anim.SetTrigger("Click");
            }

            foreach (SpriteRenderer renderer in transform.GetComponentsInChildren<SpriteRenderer>())
            {
                renderer.material = material[++mat];
            }
        }

        else if (Input.GetMouseButtonUp(0))
        {
            foreach (Animator anim in transform.GetComponentsInChildren<Animator>())
            {
                anim.ResetTrigger("Click");
                anim.SetTrigger("Release");
            }

            foreach (SpriteRenderer renderer in transform.GetComponentsInChildren<SpriteRenderer>())
            {
                renderer.material = material[mat--];
            }
        }

    }
}
