using System.Collections.Generic;
using NexusForever.Shared.Network;
using NexusForever.Shared.Network.Message;
using NexusForever.WorldServer.Game.Entity.Static;
using NexusForever.WorldServer.Network.Message.Model.Shared;

namespace NexusForever.WorldServer.Network.Message.Model
{
    [Message(GameMessageOpcode.ServerFriendshipAccountList, MessageDirection.Server)]
    public class ServerFriendshipAccountList : IWritable
    {
        public class FriendList : IWritable
        {
            public uint AccountIdFriend { get; set; }
            public ulong FriendRecordId { get; set; }
            public string PublicNote { get; set; } = "";
            public float DaysSinceLastLogin { get; set; }
            public string PrivateNote { get; set; } = "";
            public string DisplayName { get; set; } = "";
            public byte Unknown0 { get; set; }

            public List<CharacterList> CharacterList = new List<CharacterList>();

            public void Write(GamePacketWriter writer)
            {
                writer.Write(AccountIdFriend);
                writer.Write(FriendRecordId);
                writer.WriteStringWide(PublicNote);
                writer.Write(DaysSinceLastLogin);
                writer.WriteStringWide(PrivateNote);
                writer.WriteStringWide(DisplayName);
                writer.Write(Unknown0, 3u);

                writer.Write(CharacterList.Count, 32u);
                CharacterList.ForEach(c => c.Write(writer));
            }
        }

        public List<FriendList> FriendListData { get; set; } = new List<FriendList>();

        public void Write(GamePacketWriter writer)
        {
            writer.Write(FriendListData.Count, 32u);
            FriendListData.ForEach(f => f.Write(writer));
        }
    }
}
