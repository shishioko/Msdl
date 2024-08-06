﻿using System.IO;

namespace Me.Shishioko.Msdl.Data.Entities
{
    public sealed class EntityWindCharge : EntityBase
    { //TODO: check if can be spawned and why not if not
        public override int Id => 117;
        public override double Height => 0.3125;
        public override double Width => 0.3125;
        public EntityWindCharge()
        {

        }
        internal override void Serialize(Stream stream, EntityBase? rawDifference)
        {
            base.Serialize(stream, rawDifference);
        }
    }
}
