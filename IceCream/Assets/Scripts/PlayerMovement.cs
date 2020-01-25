using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls;

    Vector2 move;

    void Awake()
    {
        controls = new PlayerControls();

        controls.GamePlay1.Select.performed += ctx => PressingTwo();

        controls.GamePlay1.Move.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.GamePlay1.Move.canceled += ctx => move = Vector2.zero;
    }

    void Update()
    {
        Vector2 m = new Vector2(move.x, move.y) * Time.deltaTime;
        transform.Translate(m, Space.World);
    }

    void PressingTwo()
    {
        print("pressing two");
        transform.localScale *= 1.1f;
    }

    void OnEnable()
    {
        controls.GamePlay1.Enable();
        print("enabling");
    }

    void OnDisable()
    {
        controls.GamePlay1.Disable();
        print("disabling");
    }
}
