using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQl.Data;
using HotChocolate.Types.Relay;

namespace GraphQl.Tracks
{
    public record RenameTrackInput([ID(nameof(Track))] int Id, string Name);
}
