using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openingDoor : MonoBehaviour
{
	private Animator anim; 
	private bool openDoorBool = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Debug.Log(openDoorBool);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
        	openDoorBool = true;
            Debug.Log(openDoorBool);
        	anim.SetBool("toOpen",openDoorBool);
        }
    }
}
