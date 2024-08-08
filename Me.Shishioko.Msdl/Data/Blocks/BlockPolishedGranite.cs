﻿namespace Me.Shishioko.Msdl.Data.Blocks
{
    public sealed class BlockPolishedGranite : Block
    {
        public override int Id => 3;
        public sealed override byte LightEmit => 0;
        public sealed override byte LightFilter => 15;
        public sealed override bool SoftHitboxCollision => true;
        public sealed override bool HardHitboxCollision => true;
        public BlockPolishedGranite()
        {

        }
        public override BlockPolishedGranite Clone() => new();
    }
}
