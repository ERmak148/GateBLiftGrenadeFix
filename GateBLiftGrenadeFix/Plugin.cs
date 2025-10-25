using System;
using System.Linq;
using CommandSystem;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using Exiled.API.Enums;
using Exiled.API.Features.Toys;
using Exiled.Events.EventArgs.Player;
using Interactables.Interobjects;
using InventorySystem.Items.Firearms.ShotEvents;
using UnityEngine;

namespace GateBLiftGrenadeFix
{
    public class GateBLiftGrenadeFixPlugin : Plugin<Config>
    {
        public GateBLiftGrenadeFixPlugin()
        {
        }

        public override string Name => "GateBLiftGrenadeFix";
        public override string Author => "ermak158";

        public override PluginPriority Priority => PluginPriority.Medium;

        public GateBLiftGrenadeFixPlugin instance;

        public override void OnEnabled()
        {
            instance = this;
            Exiled.Events.Handlers.Map.Generated += OnGenerated;
            
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Map.Generated -= OnGenerated;
            instance = null;
            base.OnDisabled();
            
        }

        public void OnGenerated()
        {
            Room room = Room.Get(RoomType.EzGateB);
            Vector3 position = room.transform.TransformPoint(instance.Config.Position);
            Primitive.Create(
                primitiveType: PrimitiveType.Cube,
                position: position,
                rotation: room.Transform.rotation.eulerAngles,
                scale: instance.Config.Scale,
                spawn: true
            ).Color = Color.clear;
        }
    }

    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = true;
        public Vector3 Position { get; set; } = new Vector3(2.9f, 2.87f, -6f);
        public Vector3 Scale { get; set; } = new Vector3(1, 0.05f, 1);
    }
}