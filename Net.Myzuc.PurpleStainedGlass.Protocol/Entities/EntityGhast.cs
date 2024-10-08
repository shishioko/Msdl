﻿using System.IO;
using Net.Myzuc.PurpleStainedGlass.Protocol.Const;
using Net.Myzuc.ShioLib;

namespace Net.Myzuc.PurpleStainedGlass.Protocol.Entities
{
    public sealed class EntityGhast : EntityMob
    {
        internal override int Id => 45;
        public override double HitboxHeight => 4;
        public override double HitboxWidth => 4;
        public override bool HitboxSoftCollision => true;
        public override bool HitboxHardCollision => false;
        public override bool HitboxAlign => false;
        public bool Charging = false;
        public EntityGhast()
        {

        }
        internal override void Serialize(Stream stream, Entity? rawDifference)
        {
            base.Serialize(stream, rawDifference);
            EntityGhast? difference = rawDifference is EntityGhast castDifference ? castDifference : null;
            if (difference is not null ? difference.Charging != Charging : true)
            {
                stream.WriteU8(16);
                stream.WriteU8(MetadataType.Bool);
                stream.WriteBool(Charging);
            }
        }
        public override void CloneFrom(Entity rawEntity)
        {
            base.CloneFrom(rawEntity);
            if (rawEntity is not EntityGhast entity) return;
            Charging = entity.Charging;
        }
        public override EntityGhast Clone()
        {
            EntityGhast entity = new();
            entity.CloneFrom(this);
            return entity;
        }
    }
}
