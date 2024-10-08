﻿using Net.Myzuc.PurpleStainedGlass.Protocol.Const;
using Net.Myzuc.ShioLib;
using System.IO;

namespace Net.Myzuc.PurpleStainedGlass.Protocol.Entities
{
    public abstract class EntityGrowable : EntityMob
    {
        public bool Baby = false;
        public EntityGrowable()
        {

        }
        internal override void Serialize(Stream stream, Entity? rawDifference)
        {
            base.Serialize(stream, rawDifference);
            EntityGrowable? difference = rawDifference is EntityGrowable castDifference ? castDifference : null;
            if (difference is not null ? difference.Baby != Baby : true)
            {
                stream.WriteU8(16);
                stream.WriteU8(MetadataType.Bool);
                stream.WriteBool(Baby);
            }
        }
        public override void CloneFrom(Entity rawEntity)
        {
            base.CloneFrom(rawEntity);
            if (rawEntity is not EntityGrowable entity) return;
            Baby = entity.Baby;
        }
    }
}
