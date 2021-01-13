using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CharController : MonoBehaviour
{
  public Animator anim;
  public bool move = false;
  public float power = 2f;
  public float duration = .2f;
  public float speed = 1f;
  public List<GameObject> cluebigs;

  private AudioSource wheelchair;

  CharacterController ch;
  bool click = false;
  float down = 0f;

  void Start()
  {
    Cursor.lockState = CursorLockMode.Locked;
    Cursor.visible = false;
    ch = GetComponent<CharacterController>();
    move = false;

    wheelchair = GetComponent<AudioSource>();
  }

  void Update()
  {
    if (Input.GetMouseButtonDown(0))
    {
      if (cluebigs.Any(a => a.activeSelf))
      {
        cluebigs.Find(a => a.activeSelf).SetActive(false);
      }
      else
      {
        click = true;
        down = 0f;
      }
    }

    if (click && Input.GetMouseButton(0))
    {
      down += Time.deltaTime;
      if (down >= duration)
      {
        Move();

        wheelchair.volume = .5f;
      }
    }

    if (click && Input.GetMouseButtonUp(0))
    {
      click = false;
      if (move)
      {
        move = false;

        wheelchair.volume = 0;
      }
      else
      {
        Interact();
      }
    }

    anim.SetBool("isMoving", move);

    if (Input.GetKeyDown("escape"))
    {
      Cursor.lockState = CursorLockMode.None;
      Cursor.visible = true;
    }
    else if (Input.GetMouseButtonDown(1) && Cursor.lockState == CursorLockMode.None)
    {
      Cursor.lockState = CursorLockMode.Locked;
      Cursor.visible = false;
    }
  }

  void OnControllerColliderHit(ControllerColliderHit hit)
  {
    if (hit.transform.GetComponent<Pushable>())
    {
      Vector3 force = hit.controller.velocity * power;
      hit.collider.attachedRigidbody.AddForceAtPosition(force, hit.point);
    }
  }

  void Move()
  {
    move = true;
    float y = transform.position.y;
    ch.Move(transform.TransformDirection(Vector3.forward * speed * Time.deltaTime));
    transform.position = new Vector3(transform.position.x, y, transform.position.z);
  }

  void Interact()
  {
    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if (Physics.Raycast(ray, out hit) && hit.distance <= 3f && hit.transform.gameObject.GetComponent<Interact>())
    {
      Interact interact = hit.transform.gameObject.GetComponent<Interact>();
      interact.trigger();
    }
  }
}
