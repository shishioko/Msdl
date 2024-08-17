namespace Net.Myzuc.PurpleStainedGlass.Protocol.Blocks
{
    public sealed class BlockLilyPad : Block
    {
        public override int BlockId => 7271;
        public override int LiquidId => 0;
        public override int LightEmission => 0;
        public override int LightFilter => 0;
        public override (double xa, double ya, double za, double xb, double yb, double zb)[] Collisions => [
            (0.0625, 0, 0.0625, 0.9375, 0.09375, 0.9375)
        ];
        public BlockLilyPad()
        {
            
        }
        public override BlockLilyPad Clone()
        {
            return new();
        }
        public override Block Break()
        {
            return new BlockAir();
        }
    }
}
