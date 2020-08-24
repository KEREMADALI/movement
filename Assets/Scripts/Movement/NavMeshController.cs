using Assets.Scripts.Movement;
using UnityEngine;
using UnityEngine.AI;

internal class NavMeshController : IMovementController
{
    #region Private & Const Variables

    private NavMeshAgent m_NavMeshAgent;

    #endregion

    #region Public & Protected Variables

    #endregion

    #region Constructors

    public NavMeshController(GameObject gameObject) 
    {
        m_NavMeshAgent = gameObject.GetComponent<NavMeshAgent>();

        if (m_NavMeshAgent == null) 
        {
            m_NavMeshAgent = gameObject.AddComponent<NavMeshAgent>();
        }
    }

    #endregion

    #region Private Methods

    #endregion

    #region Public & Protected Methods		

    public void Move(Vector3 position)
    {
        m_NavMeshAgent.isStopped = false;
        m_NavMeshAgent.SetDestination(position);
    }

    public void Stop()
    {
        m_NavMeshAgent.isStopped = true;
    }

    #endregion


}