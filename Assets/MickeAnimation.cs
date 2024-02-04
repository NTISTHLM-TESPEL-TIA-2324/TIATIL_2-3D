using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MickeAnimation : MonoBehaviour
{
  void Update()
  {
    if (Input.GetAxisRaw("Jump") > 0)
    {
      GetComponent<Animator>().SetBool("walk", true);
    }
  }
}
