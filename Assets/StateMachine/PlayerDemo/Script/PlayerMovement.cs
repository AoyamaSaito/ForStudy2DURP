using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static StateMachineCrab<PlayerMovement>;

public class PlayerMovement : MonoBehaviour
{
    private enum MoveType
    {
        Move,
        Damage,
        Death
    }

    private StateMachineCrab<PlayerMovement> _stateMachine;

    private void Start()
    {
        //�X�e�[�g�}�V����`
        _stateMachine = new StateMachineCrab<PlayerMovement>(this);
        //_stateMachine.AddTransition(MoveType.Move, MoveType.Damage)
    }

    private class StateDamage : StateBase
    {
        
    }
}
