using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RedOwl.Sleipnir.Engine
{
    public interface IEnterNode
    {
        bool ActivateOnStart { get; }
    }
    
    [Serializable]
    [HideReferenceObjectPicker, InlineProperty]
    public class EnterNode : Node, IFlowOutNode, IEnterNode
    {
        [SerializeField]
        private bool activateOnStart;

        public bool ActivateOnStart => activateOnStart;

        [SerializeField]
        [FlowOut]
        protected FlowPort flowOut;

        public FlowPort FlowOut => flowOut;

        protected override void Setup()
        {
            base.Setup();
            flowOut.SetCallback(OnExit);
        }

        public virtual void OnExit() {}
    }
}