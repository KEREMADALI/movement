using UnityEngine;
using Assets.Scripts.Movement;
using Assets.Scripts.AI;

namespace Assets.Scripts.States
{
    public abstract class AbstractState : IState
    {
        #region Private & Const Variables

        #endregion

        #region Public & Protected Variables

        protected IMovementController m_MovementController;
        protected IStateController m_NpcAI;
        protected GameObject m_Target;

        #endregion

        #region Constructors

        internal AbstractState(IStateController stateController)
        {
            m_MovementController = stateController.GetMovementController();
            m_Target = stateController.GetTarget();
            m_NpcAI = stateController;
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public & Protected Methods		

        protected IState GetNextState()
        {
            return m_NpcAI.GetNextState();
        }

        public abstract IState DoAction();

        #endregion
    }
}