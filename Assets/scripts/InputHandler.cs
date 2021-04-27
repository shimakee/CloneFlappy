using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class InputHandler : MonoBehaviour
{
    [SerializeField]
    private float jumpForce = 500;

    private Rigidbody2D _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();

        if (_rb == null)
            throw new NullReferenceException("Rigidbody2d should not be null.");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnJump(InputAction.CallbackContext ctx)
    {
        if (ctx.performed && GameManager.GameStarted)
            Jump();
    }

    private void Jump()
    {
        Debug.Log($"Jumped {jumpForce}");
        _rb.AddForce(new Vector2(0, jumpForce));
    }
}
