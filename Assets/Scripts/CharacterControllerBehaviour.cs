using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CharacterControllerBehaviour : MonoBehaviour
{
    [SerializeField]
    private CharacterController _charContrl;
    private Vector3 _velocity = Vector3.zero;
    private Vector3 _inputMovement = Vector3.zero;
    private Transform _absoluteTransform;

	void Start ()
    {
        _charContrl = GetComponent<CharacterController>();

#if DEBUG

        //if (_charContrl == null)
        //{
        //    Debug.LogError("charcontrolbeghaviour needs a charactercontrolcompoment");
        //}

        Assert.IsNotNull(_charContrl, "uhm test, der is geen charcontroller  pls fix");

#endif

    }

    void Update()
    {
        _inputMovement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    void FixedUpdate ()
    {
        GroundGravity();

        ApplyGravity();

        DoMovement();
        
	}

    private void ApplyMovement()
    {

        

        
    }

    private void DoMovement()
    {
        Vector3 movement = _velocity * Time.deltaTime;

        _charContrl.Move(movement);
    }

    private void GroundGravity()
    {
        if (_charContrl.isGrounded)
        {
            _velocity -= Vector3.Project(_velocity, Physics.gravity);
        }
    }

    private void ApplyGravity()
    {
        if (!_charContrl.isGrounded)
        {
            _velocity += Physics.gravity * Time.fixedDeltaTime;
        }
    }
}
