using UnityEngine;
using System.Collections;
using Assets.Scripts.Movement;
using System;

namespace Assets.Scripts.States
{
    public class InitialState : IState
    {
        #region Private & Const Variables

        private IMovementController m_MovementController;
        private GameObject m_Target;

        #endregion

        #region Public & Protected Variables

        #endregion

        #region Constructors

        internal InitialState(GameObject target, IMovementController movementController)
        {
            m_MovementController = movementController;
            m_Target = target;
        }

        #endregion

        #region Private Methods

        private IState GetNextState()
        {
            // Insert AI here
            IState returnState = new ChaseState(m_Target, m_MovementController);

            return returnState;
        }

        #endregion

        #region Public & Protected Methods		

        public IState DoAction()
        {
            return GetNextState();
        }

        #endregion
    }
}