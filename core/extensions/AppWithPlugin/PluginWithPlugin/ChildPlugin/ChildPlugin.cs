using System;

namespace ChildPlugin
{
    public class ChildPlugin : ChildBase.ChildBase
    {
        public override string GetDescription()
        {
            return "Plugin inside another Plugin";
        }
    }
}
