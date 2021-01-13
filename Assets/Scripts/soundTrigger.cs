using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundTrigger : MonoBehaviour
{
  private AudioSource source;
  bool trigger = true;

  void Start()
  {
      source = GetComponent<AudioSource>();
  }

  void OnTriggerEnter(Collider other)
  {
      if (trigger && other.name == "Player")
      {
        if (!source.isPlaying)
        {
          source.Play();
        }
      }
  }

  void OnTriggerExit(Collider other)
  {
      if (other.name == "Player")
      {
        if (source.isPlaying)
        {
        source.Stop();
      }
        trigger = false;
      }

  }

}
