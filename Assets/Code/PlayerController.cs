using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Controller
{
    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterClockwiseKey;

    // Start is called before the first frame update
    public override void Start()
    {
        //if we have a game manager
        if(GameManager.instance != null)
        {
            //register w/game manager
            GameManager.instance.players.Add(this);
        }
        base.Start();
    }
    // Update is called once per frame
    public override void Update()
    {
        ProcessInputs();

        base.Update();
    }
    public override void ProcessInputs()
    {
        base.ProcessInputs();

        if (Input.GetKey(moveForwardKey))
        {
            pawn.MoveForward();
        }

        if (Input.GetKey(moveBackwardKey))
        {
            pawn.MoveBackward();
        }

        if (Input.GetKey(rotateClockwiseKey))
        {
            pawn.RotateClockwise();
        }

        if (Input.GetKey(rotateCounterClockwiseKey))
        {
            pawn.RotateCounterClockwise();
        }
    }
    public void OnDestroy()
    {
        //if there is a game manager
        if (GameManager.instance != null) 
        {
            //instance tarcks destroyed player
            if (GameManager.instance.players != null)
            {
                //deregister w/game manager
                GameManager.instance.players.Remove(this);
            }
        }
    }
}