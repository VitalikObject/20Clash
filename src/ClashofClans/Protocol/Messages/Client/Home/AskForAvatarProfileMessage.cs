﻿using ClashofClans.Logic;
using ClashofClans.Protocol.Messages.Server;
using DotNetty.Buffers;

namespace ClashofClans.Protocol.Messages.Client.Home
{
    public class AskForAvatarProfileMessage : PiranhaMessage
    {
        public AskForAvatarProfileMessage(Device device, IByteBuffer buffer) : base(device, buffer)
        {
            RequiredState = Device.State.NotDefinied;
        }

        public long UserId { get; set; }

        public override void Decode()
        {
            UserId = Reader.ReadLong();

            var hasHomeId = Reader.ReadBoolean();

            if (hasHomeId)
                Reader.ReadLong();
        }

        public override async void Process()
        {
            /*await new AvatarProfileMessage(Device)
            {
                Player = await Resources.Players.GetPlayerAsync(UserId)
            }.SendAsync();*/
        }
    }
}