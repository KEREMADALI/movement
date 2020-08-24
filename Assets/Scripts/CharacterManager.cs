using Assets.Scripts.Movement;
using Assets.Scripts.States;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    #region Private & Const Variables

    private IMovementController m_MovementController;
    
    [SerializeField]
    private GameObject m_Target;
    private IState m_CurrentState;

    #endregion

    #region Public & Protected Variables


    #endregion

    #region Constructors

    #endregion

    #region Private Methods

    private void Start()
    {
        m_MovementController = new NavMeshController(gameObject);
        m_CurrentState = new InitialState(m_Target, m_MovementController);
    }

    private void Update()
    {
        if (m_Target == null)
        {
            throw new System.Exception("Target can not be null in ChracterManager");
        }

        m_MovementController.Move(m_Target.transform.position);

        m_CurrentState = m_CurrentState.DoAction();
    }

    #endregion

    #region Public & Protected Methods		

    #endregion
}
