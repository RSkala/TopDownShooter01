using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D _rigidBody2D;

    [SerializeField]
    float _speed;

    Vector2 _moveInput;
    int _facingDirection = 1;

    void Start()
    {
        
    }

    void Update()
    {
        if (_moveInput.x > 0.1f && _facingDirection < 0 || _moveInput.x < -0.1f && _facingDirection > 0)
        {
            // Pressing RIGHT while facing LEFT OR Pressing LEFT while facing RIGHT
            Flip();
        }
    }

    void FixedUpdate()
    {
        _rigidBody2D.linearVelocity = _moveInput * _speed;
    }

    // We are using "Send Messages" in the PlayerInput component, so the method passes InputValue instead of the context
    public void OnMove(InputValue inputValue)
    {
        //Debug.Log($"OnMove - inputValue: {inputValue}");

        _moveInput = inputValue.Get<Vector2>();
    }

    void Flip()
    {
        _facingDirection *= -1;
        Vector3 localScale = transform.localScale;
        localScale.x = _facingDirection;
        transform.localScale = localScale;
    }
}
