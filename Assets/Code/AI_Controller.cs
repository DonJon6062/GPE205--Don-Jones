using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class AI_Controller : Controller
{
    public enum AIState {Idle, Chase, Flee, Patrol, Attack, Scan, BackToPost }

    public AIState currentState;

    //private

    public GameObject target;
    
    // Start is called before the first frame update
    public override void Start()
    {
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
        Debug.Log("moving");
        switch(currentState)
        {
            case AIState.Idle:
                //guard and check for transitions
                DoIdleState();
                break;
            case AIState.Chase:
                //chase and check for transitions
                DoChaseState();
                break;
        }
    }

    protected void DoIdleState() 
    { 
        //Do Nada
    }

    protected void DoChaseState() 
    {
        //Seek Target
        pawn.RotateTowards(target.transform.position);
        // Move Forward
        pawn.MoveForward();
    }

    public void Seek(GameObject target)
    { 
        //Face Target

        //Move to target
    }
    public void Seek(Vector3 targetPosition) 
    {
        //Do Seek Behavior
    }

    protected bool IsDistanceLessThan(GameObject target, float distance)
    {
        if (Vector3.Distance(pawn.transform.position, target.transform.position) < distance)
        {
            return true;
        }

        else
        { 
            return false;
        }
    }

    public virtual void ChangeState(AIState newState)
    { 
        
    }
}
