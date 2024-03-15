using UnityEngine;

namespace StateController
{
    [DisallowMultipleComponent]
    public class StateActive : BaseBooleanLogicState
    {
        private GameObject m_GameObject;
        
        protected internal override void OnInit()
        {
            base.OnInit();
            m_GameObject = gameObject;
        }
        
        protected override void OnStateChanged(bool logicResult)
        {
            m_GameObject.SetActive(logicResult);
        }
    }
}