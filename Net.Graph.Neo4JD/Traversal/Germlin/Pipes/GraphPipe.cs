﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Net.Graph.Neo4JD.Traversal.Germlin.Pipes
{
    public class GraphPipe:Pipe 
    {
        public GraphPipe()
        {
            base.SetPipeName("g");
        }
    }
}
