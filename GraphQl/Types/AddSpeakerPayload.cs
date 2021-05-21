using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConferencePlanner.GraphQL.Data;
using GraphQl.Common;
using GraphQl.Types;

namespace GraphQl
{
    public class AddSpeakerPayload : SpeakerPayloadBase
    {
        public AddSpeakerPayload(Speaker speaker) : base(speaker)
        {
        }

        public AddSpeakerPayload(IReadOnlyList<UserError> errors) : base(errors)
        {
        }
    }
}
