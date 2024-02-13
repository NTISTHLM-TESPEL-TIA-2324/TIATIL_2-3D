using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
  CharacterController controller;
  Animator animator;
  Vector2 inputVector;

  [SerializeField]
  float speed = 3;

  void Start()
  {
    controller = GetComponent<CharacterController>();
    animator = GetComponent<Animator>();
  }

  void Update()
  {
    Vector3 movement = 
        Camera.main.transform.right * inputVector.x
      + Camera.main.transform.forward * inputVector.y;

    if (movement.magnitude > 0)
    {
      movement.y = 0;
      movement = movement.normalized;

      transform.forward = movement;
      animator.SetBool("walk", true);
    }
    else
    {
      animator.SetBool("walk", false);
    }

    movement = movement * speed * Time.deltaTime;
    controller.Move(movement);
  }

  void OnMove(InputValue value)
  {
    inputVector = value.Get<Vector2>();
  }
}
