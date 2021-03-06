﻿using Assets.Scripts.AI;

namespace Assets.Scripts.States
{
    public class ChaseState : AbstractState
    {
        #region Private & Const Variables

        #endregion

        #region Public & Protected Variables

        #endregion

        #region Constructors

        public ChaseState(IStateController stateController) 
            : base(stateController) 
        { 
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public & Protected Methods		

        public override IState DoAction()
        {
            m_MovementController.Move(m_Target.transform.position);

            return GetNextState();
        }

        #endregion
    }
}