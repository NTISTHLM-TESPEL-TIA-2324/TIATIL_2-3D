using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
  CharacterController controller;
  Vector2 inputVector;

  [SerializeField]
  float speed = 3;

  void Start()
  {
    controller = GetComponent<CharacterController>();
  }

  void Update()
  {
    Vector3 movement = new (
      inputVector.x,
      0,
      inputVector.y
    );
    
    movement = movement * speed * Time.deltaTime;
    controller.Move(movement);
  }

  void OnMove(InputValue value)
  {
    inputVector = value.Get<Vector2>();
  }
}
