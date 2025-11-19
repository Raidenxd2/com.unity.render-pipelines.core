namespace UnityEngine.Rendering.RenderGraphModule
{
    internal sealed class RenderGraphEditorLocalDebugSession : RenderGraphDebugSession
    {
        public override bool isActive => true;

        public RenderGraphEditorLocalDebugSession() : base()
        {
            RegisterAllLocallyKnownGraphsAndExecutions();
        }
    }
}
