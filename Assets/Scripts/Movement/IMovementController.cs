using UnityEngine;
using System.Collections;

namespace Assets.Scripts.Movement
{
    public interface IMovementController
    {
        void Move(Vector3 position);

        void Stop();
    }
}