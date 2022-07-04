using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MeasuringDevice
{

    public interface IEventEnabledMeasuringDevice : IMeasuringDevice
    {

        event EventHandler NewMeasurementTaken;
    }
    
}
