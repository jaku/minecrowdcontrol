using System;
using System.Collections.Generic;
using CrowdControl.Common;
using CrowdControl.Games.Packs;
using ConnectorType = CrowdControl.Common.ConnectorType;

public class Minecraft : SimpleTCPPack
{
    public override string Host => "127.0.0.1";

    public override ushort Port => 58430;

    public Minecraft(IPlayer player, Func<CrowdControlBlock, bool> responseHandler, Action<object> statusUpdateHandler) : base(player, responseHandler, statusUpdateHandler) { }

    public override Game Game => new Game(53, "Minecraft", "minecraft", "PC", ConnectorType.SimpleTCPConnector);

    public override List<Effect> Effects => new List<Effect>
    {
        new Effect("Kill the Player", "kill"),
        new Effect("Take one Heart", "take_heart"),
        new Effect("Give one Heart", "give_heart"),
        new Effect("Set Fire", "set_fire"),
        new Effect("Spawn Creeper", "spawn_creeper"),
        new Effect("Set Time Night", "set_time_night"),
        new Effect("Set Time Day", "set_time_day"),
        new Effect("Take one food", "take_food"),
        new Effect("Give one food", "give_food")
    };
}