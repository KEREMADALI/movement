using Assets.Scripts.AI;
using Assets.Scripts.Movement;
using Assets.Scripts.States;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    #region Private & Const Variables

    [SerializeField]
    private GameObject m_Target;
    private IState m_CurrentState;
    
    #endregion

    #region Public & Protected Variables

    public IStateController SimpleAI;
    public IMovementController MovementController;

    #endregion

    #region Constructors

    #endregion

    #region Private Methods

    private void Start()
    {
        // Change controller according to will
        MovementController = new NavMeshController(gameObject);

        // Change controller according to will
        SimpleAI = new SimpleAI(transform, m_Target, MovementController);
        m_CurrentState = new IdleState(SimpleAI);
    }

    private void Update()
    {
        if (m_Target == null)
        {
            throw new System.Exception("Target can not be null in CharacterManager");
        }

        m_CurrentState = m_CurrentState.DoAction();
    }

    #endregion

    #region Public & Protected Methods		

    #endregion
}
