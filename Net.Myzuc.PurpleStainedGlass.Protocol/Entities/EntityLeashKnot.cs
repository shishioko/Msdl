﻿namespace Net.Myzuc.PurpleStainedGlass.Protocol.Entities
{
    public sealed class EntityLeashKnot : Entity
    {
        internal override int Id => 63;
        public override double HitboxHeight => 0.5;
        public override double HitboxWidth => 0.375;
        public override bool HitboxSoftCollision => false;
        public override bool HitboxHardCollision => false;
        public override bool HitboxAlign => true;
        public EntityLeashKnot()
        {

        }
        public override EntityLeashKnot Clone()
        {
            EntityLeashKnot entity = new();
            entity.CloneFrom(this);
            return entity;
        }
    }
}
