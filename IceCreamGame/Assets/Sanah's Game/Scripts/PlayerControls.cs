﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    PlayerInput controls;
    public bool buttonPress;
    Vector3 move;
    Rigidbody rb;
    public float speed;
    public int counterVal;
    private int counter;
    Quaternion dirToFace;

    private void Awake()
    {
        buttonPress = false;
        controls = new PlayerInput();
        rb = GetComponent<Rigidbody>();

        controls.gameplay.select.performed += ctx => PressingTwo();

        controls.gameplay.move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.gameplay.move.canceled += ctx => move = Vector3.zero;
    }

    private void FixedUpdate()
    {
        Vector3 m = new Vector3(move.x, 0, move.y) * Time.deltaTime;
        rb.velocity = m * speed;

        Vector3 lookDirection = new Vector3(move.x, 0, move.y);
        if (lookDirection != Vector3.zero)
            dirToFace = Quaternion.LookRotation(lookDirection);

        transform.rotation = Quaternion.Slerp(transform.rotation, dirToFace, Time.deltaTime * 5f);

        if (counter > 0)
        {
            counter--;
        }
        else
            ConsumeButton();

    }

    void PressingTwo()
    {
        //print("pressing two");
        buttonPress = true;
        counter = counterVal;
    }

    private void OnEnable()
    {
        controls.gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.gameplay.Disable();
    }

    public void ConsumeButton()
    {
        buttonPress = false;
        counter = 0;
    }
}
