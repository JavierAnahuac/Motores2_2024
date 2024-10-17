using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationAction : AIAction
{
    public override void PerformAction(){}

    public override void OnEnterState(){
        base.OnEnterState();

        if(_brain.CurrentState.StateName == "Idle"){
            GetComponentInChildren<Animator>().SetBool("IsFollowing", false);
            return;
        }

        if(_brain.CurrentState.StateName == "FollowTarget"){
            GetComponentInChildren<Animator>().SetBool("IsFollowing", true);
            return;
        }
    }
}
