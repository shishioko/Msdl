namespace Net.Myzuc.PurpleStainedGlass.Protocol.Blocks
{
    public sealed class BlockLilyOfTheValley : Block
    {
        public override int BlockId => 2088;
        public override int LiquidId => 0;
        public override int LightEmission => 0;
        public override int LightFilter => 0;
        public override (double xa, double ya, double za, double xb, double yb, double zb)[] Collisions => [];
        public BlockLilyOfTheValley()
        {
            
        }
        public override BlockLilyOfTheValley Clone()
        {
            return new();
        }
        public override Block Break()
        {
            return new BlockAir();
        }
    }
}
