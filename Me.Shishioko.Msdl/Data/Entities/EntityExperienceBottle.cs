﻿namespace Me.Shishioko.Msdl.Data.Entities
{
    public sealed class EntityExperienceBottle : EntityItemProjectile
    {
        internal override int Id => 37;
        public override double HitboxHeight => 0.25;
        public override double HitboxWidth => 0.25;
        public override bool HitboxSoftCollision => false;
        public override bool HitboxHardCollision => false;
        public override bool HitboxAlign => false;
        public EntityExperienceBottle() : base(1088) //TODO: read xp bottle id from item list
        {

        }
    }
}