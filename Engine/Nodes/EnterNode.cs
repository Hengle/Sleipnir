using System;
using Sirenix.OdinInspector;
using UnityEngine;

namespace RedOwl.Sleipnir
{
    [Serializable]
    [HideReferenceObjectPicker, InlineProperty]
    public class EnterNode : Node, IFlowOutNode
    {
        [SerializeField]
        protected FlowOut flowOut;

        public FlowOut FlowOut => flowOut;

        protected override void Setup()
        {
            base.Setup();
            flowOut.SetCallback(OnExit);
        }

        public virtual void OnExit() {}
    }
}