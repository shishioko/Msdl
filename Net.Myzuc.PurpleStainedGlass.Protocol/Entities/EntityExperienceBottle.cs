﻿using Net.Myzuc.PurpleStainedGlass.Protocol.Items;

namespace Net.Myzuc.PurpleStainedGlass.Protocol.Entities
{
    public sealed class EntityExperienceBottle : EntityItemProjectile
    {
        internal override int Id => 37;
        public override double HitboxHeight => 0.25;
        public override double HitboxWidth => 0.25;
        public override bool HitboxSoftCollision => false;
        public override bool HitboxHardCollision => false;
        public override bool HitboxAlign => false;
        public EntityExperienceBottle() : base(new ItemExperienceBottle())
        {

        }
        public override EntityExperienceBottle Clone()
        {
            EntityExperienceBottle entity = new();
            entity.CloneFrom(this);
            return entity;
        }
    }
}
