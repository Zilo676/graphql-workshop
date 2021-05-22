using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl.Common;
using GraphQl.Data;

namespace GraphQl.Tracks
{
    public class AddTrackPayload : TrackPayloadBase
    {
        public AddTrackPayload(Track track)
            : base(track)
        {
        }

        public AddTrackPayload(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }
    }
}
