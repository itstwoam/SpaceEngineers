﻿using ProtoBuf;
using Sandbox.Common.ObjectBuilders.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox.Common.ObjectBuilders
{
    [ProtoContract]
    //[MyObjectBuilderDefinition]
    public class MyObjectBuilder_MissionTriggers : MyObjectBuilder_Base
    {
        [ProtoMember(1)]
        public List<MyObjectBuilder_Trigger> WinTriggers =new List<MyObjectBuilder_Trigger>();
        [ProtoMember(2)]
        public List<MyObjectBuilder_Trigger> LoseTriggers =new List<MyObjectBuilder_Trigger>();

    }
}
