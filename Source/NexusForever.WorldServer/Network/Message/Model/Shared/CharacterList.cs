using NexusForever.Shared.Network;
using NexusForever.Shared.Network.Message;
using NexusForever.WorldServer.Game.Entity.Static;

namespace NexusForever.WorldServer.Network.Message.Model.Shared
{
    public class CharacterList : IWritable
    {
        public string CharacterName { get; set; } = "";
        public CharacterIdentity CharacterIdentityData  { get; set; } = new CharacterIdentity();
        public ushort ClassId { get; set; }
        public ushort RaceId  { get; set; }
        public uint PathType { get; set; }
        public uint Level { get; set; }
        public ushort WorldZoneId { get; set; }
        public ushort Unknown0 { get; set; }

        public void Write(GamePacketWriter writer)
        {
            writer.WriteStringWide(CharacterName);
            CharacterIdentityData.Write(writer);
            writer.Write(ClassId, 14u);
            writer.Write(RaceId, 14u);
            writer.Write(PathType);
            writer.Write(Level);
            writer.Write(WorldZoneId, 15u);
            writer.Write(Unknown0, 14u);
        }
    }
}

