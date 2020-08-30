using UnityEngine;
using Assets.Scripts.States;
using Assets.Scripts.Movement;

namespace Assets.Scripts.AI
{
    public class SimpleAI : IStateController
    {
        #region Private & Const Variables

        private const float m_SqrDistanceLimitToTarget = 16f; 

        /// <summary>
        /// Target object of the AI
        /// </summary>
        private GameObject m_Target;

        /// <summary>
        /// Movement controller of the NPC, it is being used in states
        /// </summary>
        private IMovementController m_MovementController;

        /// <summary>
        /// Transform of the AI itself
        /// </summary>
        private Transform m_Transform;

        #endregion

        #region Public & Protected Variables

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="transform"></param>
        /// <param name="target"></param>
        /// <param name="movementController"></param>
        public SimpleAI(Transform transform, GameObject target, IMovementController movementController) 
        {
            m_Transform = transform;
            m_Target = target;
            m_MovementController = movementController;
        }

        #endregion

        #region Private Methods

        #endregion

        #region Public & Protected Methods		

        #endregion

        /// <summary>
        /// Determines the next state of the NPC
        /// </summary>
        /// <returns></returns>
        public IState GetNextState()
        {
            bool isTooFar = m_Transform.SquareDistanceTo(m_Target.transform) > m_SqrDistanceLimitToTarget;
            IState returnState;

            if (isTooFar)
            {
                returnState = new ChaseState(this);
            }
            else 
            { 
                returnState = new IdleState(this);
            }

            return returnState;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IMovementController GetMovementController() 
        {
            return m_MovementController;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public GameObject GetTarget()
        {
            return m_Target;
        }
    }
}