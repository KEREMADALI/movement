using System;
using System.Linq;
using UnityEngine;

public class TeleportManager : MonoBehaviour
{
	#region Private & Const Variables

	private const float s_TeleportInterval = 2f;

    [SerializeField]
    private Transform m_Area;
    private Transform m_Transform;
    private float m_Timer;
    private float s_TeleportRangeX;
    private float s_TeleportRangeZ;

    #endregion

    #region Public & Protected Variables

    #endregion

    #region Constructors

    #endregion

    #region Private Methods

    private void Start()
    {
        m_Transform = transform;

        if (m_Area == null) 
        {
            throw new Exception("Area transform can not be null in TeleportManager");
        }

        s_TeleportRangeX = m_Area.localScale.x / 2;
        s_TeleportRangeZ = m_Area.localScale.z / 2;
    }

    private void Update()
    {
        if (CheckTimer())
        {
            return;
        }

        Teleport();
    }

    /// <summary>
    /// Teleports object into a different location on plane
    /// </summary>
    private void Teleport()
    {
        Vector3 nextPosition = Vector3.zero;

        while(nextPosition == Vector3.zero) 
        {
            nextPosition = GetRandomPosition();
            nextPosition = IsInRange(nextPosition) ? nextPosition : Vector3.zero;
        }

        m_Transform.position = nextPosition;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="position"></param>
    /// <returns></returns>
    private bool IsInRange(Vector3 position)
    {
        var hitColliders = Physics.OverlapSphere(position, 1f).ToList();

        return hitColliders.Any();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private Vector3 GetRandomPosition()
    {
        float x = UnityEngine.Random.Range(-s_TeleportRangeX, s_TeleportRangeX);
        float z = UnityEngine.Random.Range(-s_TeleportRangeZ, s_TeleportRangeZ);

        return new Vector3(x, m_Transform.position.y, z);
    }

    /// <summary>
    /// Returns true if the timer is not finished yet
    /// </summary>
    /// <returns></returns>
    private bool CheckTimer()
    {
        m_Timer += Time.deltaTime;

        if (m_Timer < s_TeleportInterval) 
        {
            return true;
        }

        m_Timer = 0f;

        return false;
    }

    #endregion

    #region Public & Protected Methods		

    #endregion
}
