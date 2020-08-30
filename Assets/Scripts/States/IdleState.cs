using Assets.Scripts.AI;

namespace Assets.Scripts.States
{
    public class IdleState : AbstractState
    {
        #region Private & Const Variables

        #endregion

        #region Public & Protected Variables

        #endregion

        #region Constructors

        public IdleState(IStateController stateController) 
            : base(stateController) 
        { 
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public & Protected Methods		

        public override IState DoAction()
        {
            m_MovementController.Stop();

            return GetNextState();
        }

        #endregion
    }
}