using UnityEngine;
using System.Collections;
using Assets.Scripts.States;
using Assets.Scripts.Movement;

namespace Assets.Scripts.AI
{
    public interface IStateController
    {
        IState GetNextState();

        IMovementController GetMovementController();

        GameObject GetTarget();
    }
}