using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : Interact
{
  public GameObject clue;
  public GameObject cluebig;

  public override void trigger()
  {
    clue.SetActive(true);
    cluebig.SetActive(true);
  }
}
