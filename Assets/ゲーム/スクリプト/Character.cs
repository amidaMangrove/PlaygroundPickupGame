﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private UIScript userInterface;

    Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        userInterface = GameObject.FindObjectOfType<UIScript>();
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Pickup") {

            if (userInterface != null) {
                // add one point
                userInterface.AddPoints(0, 1);
            }
            _anim.SetTrigger("Happy");

            // then destroy this object
            Destroy(collision.gameObject);
        }
    }
   
}
