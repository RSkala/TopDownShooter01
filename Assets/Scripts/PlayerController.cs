using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D _rigidBody2D;

    [SerializeField]
    float _speed;

    Vector2 _moveInput;

    void Start()
    {
        
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
}
