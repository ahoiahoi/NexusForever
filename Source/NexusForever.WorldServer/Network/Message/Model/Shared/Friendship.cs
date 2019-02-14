using NexusForever.Shared.Network;
using NexusForever.Shared.Network.Message;
using NexusForever.WorldServer.Game.Entity.Static;

namespace NexusForever.WorldServer.Network.Message.Model.Shared
{
    public class Friendship : IWritable
    {
        public long FriendshipId { get; set; }
        public CharacterIdentity IdentityData { get; set; } = new CharacterIdentity();
        public string Note { get; set; } = "";
        public byte Type { get; set; }

        public void Write(GamePacketWriter writer)
        {
            writer.Write(FriendshipId);
            IdentityData.Write(writer);
            writer.WriteStringWide(Note);
            writer.Write(Type, 4u);
        }
    }
}

