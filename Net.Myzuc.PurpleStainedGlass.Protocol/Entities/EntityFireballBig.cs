﻿using Net.Myzuc.PurpleStainedGlass.Protocol.Items;

namespace Net.Myzuc.PurpleStainedGlass.Protocol.Entities
{
    public sealed class EntityFireballBig : EntityItemProjectile
    {
        internal override int Id => 62;
        public override double HitboxHeight => 1;
        public override double HitboxWidth => 1;
        public override bool HitboxSoftCollision => false;
        public override bool HitboxHardCollision => false;
        public override bool HitboxAlign => false;
        public EntityFireballBig() : base(new ItemFireCharge())
        {

        }
        public override EntityFireballBig Clone()
        {
            EntityFireballBig entity = new();
            entity.CloneFrom(this);
            return entity;
        }
    }
}
