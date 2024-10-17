using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerExitDecision : AIDecision
{
    private bool hasPlayerEnter;

    public override void Initialization()
    {
        hasPlayerEnter = false;
    }

    public override bool Decide()
    {
        return hasPlayerEnter;
    }

    private void OnTriggerExit(Collider other) {
       if(other.gameObject.tag == "Player" && _brain.Target != null){
            hasPlayerEnter = true;
            _brain.Target = null;
       }
    }

    public override void OnEnterState()
    {
        base.OnEnterState();
        hasPlayerEnter = false;
    }
}
