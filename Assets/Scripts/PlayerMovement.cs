using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 6;

    Vector2 _inputValues;

    // Update is called once per frame
    void Update()
    {
        _inputValues = GetInputValues();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        rb.velocity = new Vector3(GetInputValues().x * speed, rb.velocity.y, GetInputValues().y * speed);
    }

    private Vector3 GetInputValues()
    {
        return new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
}
