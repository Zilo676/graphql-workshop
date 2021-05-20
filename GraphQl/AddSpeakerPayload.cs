using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConferencePlanner.GraphQL.Data;

namespace GraphQl
{
    public class AddSpeakerPayload
    {
        public Speaker Speaker { get; }
        public AddSpeakerPayload(Speaker speaker)
        {
            Speaker = speaker;
        }
    }
}
