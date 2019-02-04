using System.Collections.Generic;
using NexusForever.Shared.Network;
using NexusForever.Shared.Network.Message;

namespace NexusForever.WorldServer.Game.Entity.Network.Model
{
    public class StructuredPlugEntityModel : IEntityModel
    {
        public uint CreatureId { get; set; }
        public byte Unknown0 { get; set; }
        public ushort SocketId { get; set; }

        public void Write(GamePacketWriter writer)
        {
            writer.Write(CreatureId, 18u);
            writer.Write(Unknown0, 2u);
            writer.Write(SocketId, 14u);
        }
    }
}
