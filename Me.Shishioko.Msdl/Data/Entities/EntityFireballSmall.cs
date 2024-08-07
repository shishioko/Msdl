﻿using Me.Shishioko.Msdl.Data.Items;

namespace Me.Shishioko.Msdl.Data.Entities
{
    public sealed class EntityFireballSmall : EntityItemProjectile
    {
        internal override int Id => 94;
        public override double HitboxHeight => 0.3125;
        public override double HitboxWidth => 0.3125;
        public override bool HitboxSoftCollision => false;
        public override bool HitboxHardCollision => false;
        public override bool HitboxAlign => false;
        public EntityFireballSmall() : base(new ItemFireCharge())
        {

        }
        public override EntityFireballSmall Clone()
        {
            EntityFireballSmall entity = new();
            entity.CloneFrom(this);
            return entity;
        }
    }
}
