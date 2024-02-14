using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LookController : MonoBehaviour
{
  [SerializeField]
  Vector2 sensitivity = Vector2.one;

  GameObject head;
  float xRotation = 0;

  void Awake()
  {
    Cursor.lockState = CursorLockMode.Locked;
    head = GetComponentInChildren<Camera>().gameObject;
  }

  void OnLook(InputValue value)
  {
    Vector2 lookVector = value.Get<Vector2>();
    float yRotation = lookVector.x * sensitivity.x;
    transform.Rotate(Vector3.up, yRotation);

    float xDegrees = lookVector.y * sensitivity.y;
    xRotation += xDegrees;
    head.transform.localEulerAngles = new(-xRotation, 0, 0);

  }

}
