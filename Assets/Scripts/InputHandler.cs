using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public GameObject actor;
    Animator animator;
    Command keySpace, keyP, keyK, upArrow;
    // Start is called before the first frame update
    void Start()
    {
        keySpace = new DoJumping();
        keyP = new DoPunching();
        keyK = new DoKicking();
        upArrow = new MoveForward();
        animator = actor.GetComponent<Animator>();
        Camera.main.GetComponent<CameraFollow360>().player = actor.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            upArrow.Execute(animator);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            keySpace.Execute(animator);
        }
        else if(Input.GetKeyDown(KeyCode.P))
        {
            keyP.Execute(animator);
        }
        else if (Input.GetKeyDown(KeyCode.K))
        {
            keyK.Execute(animator);
        }

    }
}
