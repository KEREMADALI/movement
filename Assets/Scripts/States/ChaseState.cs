using UnityEngine;
using System.Collections;
using Assets.Scripts.Movement;

namespace Assets.Scripts.States
{
    public class ChaseState : InitialState
    {
        #region Private & Const Variables

        #endregion

        #region Public & Protected Variables

        #endregion

        #region Constructors

        public ChaseState(GameObject target, IMovementController movementController) 
            : base(target, movementController) 
        { 
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public & Protected Methods		

        public IState DoAction()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}