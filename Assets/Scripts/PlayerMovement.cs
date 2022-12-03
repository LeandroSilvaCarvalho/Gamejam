using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Animator animator;
    private Rigidbody rigidbody;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void FixedUpdate()
    {
        TakeInput();
        Move();
    }

    private void TakeInput()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        direction = new Vector3(horizontalInput, 0, verticalInput);
    }

    private void Move()
    {
        //var newPos = transform.position;
        //newPos += direction * Time.deltaTime * speed;
        //transform.position = newPos;
        //rigidbody.MovePosition(transform.position + direction * Time.fixedDeltaTime *speed);
        rigidbody.velocity = direction * speed;
        //rigidbody.AddForce(new Vector3(0,-7,0)*speed,ForceMode.Acceleration);
        

        //if (direction.x != 0 || direction.z != 0)
        //{
        SetAnimatorMovement(direction);
        //}
        //else
        //{
        //animator.SetLayerWeight(1, 0);
        //}
    }

    private void SetAnimatorMovement(Vector3 direction)
    {
        //animator.SetLayerWeight(1, 1);
        animator.SetFloat("xDir", direction.x);
        animator.SetFloat("zDir", direction.z);
    }
}