using System;

namespace Dalamud.Game.ClientState
{
    public class JobGauges
    {
        // Should only be called with the gauge types in 
        // ClientState.Structs.JobGauge
        public T Get<T>()
        {
            throw new NotImplementedException();
        }
    }
}
