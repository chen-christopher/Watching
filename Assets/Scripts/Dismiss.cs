using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dismiss : MonoBehaviour
{
  void OnMouseDown()
  {
    gameObject.SetActive(false);
  }
}
