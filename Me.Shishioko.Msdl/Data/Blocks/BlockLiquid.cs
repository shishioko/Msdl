﻿namespace Me.Shishioko.Msdl.Data.Blocks
{
    public abstract class BlockLiquid : Block
    {
        internal abstract int BaseId { get; }
        public sealed override int Id => BaseId + (InternalState & 15);
        public sealed override bool SoftHitboxCollision => false;
        public sealed override bool HardHitboxCollision => false;
        private byte InternalState = 0;
        public int Level
        {
            get => 7 - (InternalState & 7);
            set 
            {
                InternalState &= 8;
                InternalState |= (byte)((value & 7) - 7);
            }
        }
        public bool Flowing
        {
            get => (InternalState & 8) != 0;
            set 
            {
                InternalState &= 7;
                if (value) InternalState |= 8;
            }
        }
        internal BlockLiquid()
        {

        }
    }
}
