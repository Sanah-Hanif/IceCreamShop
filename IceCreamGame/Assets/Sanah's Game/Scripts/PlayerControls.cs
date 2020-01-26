﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    PlayerInput controls;
    Vector3 move;
    Rigidbody rb;
    public float speed;

    private void Awake()
    {
        controls = new PlayerInput();
        rb = GetComponent<Rigidbody>();

        controls.gameplay.select.performed += ctx => PressingTwo();

        controls.gameplay.move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.gameplay.move.canceled += ctx => move = Vector3.zero;
    }

    private void Update()
    {
        Vector3 m = new Vector3(move.x, 0, move.y) * Time.deltaTime;
        rb.velocity = m * speed;

        Vector3 lookDirection = new Vector3(move.x, 0, move.y);
        transform.rotation = Quaternion.LookRotation(lookDirection);
    }

    void PressingTwo()
    {
        print("pressing two");
    }

    private void OnEnable()
    {
        controls.gameplay.Enable();
    }

    private void OnDisable()
    {
        controls.gameplay.Disable();
    }
}
