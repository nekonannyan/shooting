using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    Rigidbody rb;
    float speed = 3.0f;
    float rotateSpeed = 0.3f;

    Animator animator;

    float horizonralInput, vertonralInput;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        horizonralInput = Input.GetAxisRaw("Horizonral");
        vertonralInput = Input.GetAxisRaw("Vertonal");

    }
}
