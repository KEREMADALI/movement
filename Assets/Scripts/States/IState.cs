using UnityEngine;
using System.Collections;

namespace Assets.Scripts.States
{
    public interface IState
    {
        IState DoAction();
    }
}