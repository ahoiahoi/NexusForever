using System.Collections.Generic;
using NexusForever.Shared.Network;
using NexusForever.Shared.Network.Message;
using NexusForever.WorldServer.Game.Entity.Static;
using NexusForever.WorldServer.Network.Message.Model.Shared;

namespace NexusForever.WorldServer.Network.Message.Model
{
    [Message(GameMessageOpcode.ServerFriendshipList, MessageDirection.Server)]
    public class ServerFriendshipList : IWritable
    {
        public List<Friendship> Friendships { get; set; } = new List<Friendship>();

        public void Write(GamePacketWriter writer)
        {
            writer.Write(Friendships.Count, 16u);
            Friendships.ForEach(f => f.Write(writer));
        }
        
/*  public byte[] bla = new byte[] {0x02,0x00,0xCB,0x50,0x03,0x00,0x00,0x00,0x00,0x1A,0x84,0x41,0x85,0x8C,0x01,0x00,0x00,0x00,0x80,0x06,0x00,0xDC,0x0A,0x39,0x00,0x00,0x00,0x00,0x68,0x10,0x06,0x8B,0xD7,0x05,0x00,0x00,0x00,0x00,0x1C,0x00,0x00};
public void Write(GamePacketWriter writer)
        {
            writer.WriteBytes(bla);
        }*/
    }
}
