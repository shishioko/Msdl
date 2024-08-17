namespace Net.Myzuc.PurpleStainedGlass.Protocol.Blocks
{
    public sealed class BlockSoulFire : Block
    {
        public override int BlockId => 2872;
        public override int LiquidId => 0;
        public override int LightEmission => 10;
        public override int LightFilter => 0;
        public override (double xa, double ya, double za, double xb, double yb, double zb)[] Collisions => [];
        public BlockSoulFire()
        {
            
        }
        public override BlockSoulFire Clone()
        {
            return new();
        }
        public override Block Break()
        {
            return new BlockAir();
        }
    }
}