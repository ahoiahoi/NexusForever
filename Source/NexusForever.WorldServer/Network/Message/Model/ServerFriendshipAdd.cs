using NexusForever.Shared.Network;
using NexusForever.Shared.Network.Message;
using NexusForever.WorldServer.Game.Entity.Static;
using NexusForever.WorldServer.Network.Message.Model.Shared;

namespace NexusForever.WorldServer.Network.Message.Model
{
    [Message(GameMessageOpcode.ServerFriendshipAdd, MessageDirection.Server)]
    public class ServerFriendshipAdd : IWritable
    {
        public Friendship Friendship { get; set; } = new Friendship();

        public void Write(GamePacketWriter writer)
        {
            Friendship.Write(writer);
        }
    }
}
