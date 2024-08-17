namespace Net.Myzuc.PurpleStainedGlass.Protocol.Blocks
{
    public sealed class BlockRedConcrete : Block
    {
        public override int BlockId => 12742;
        public override int LiquidId => 0;
        public override int LightEmission => 0;
        public override int LightFilter => 15;
        public override (double xa, double ya, double za, double xb, double yb, double zb)[] Collisions => [
            (0, 0, 0, 1, 1, 1)
        ];
        public BlockRedConcrete()
        {
            
        }
        public override BlockRedConcrete Clone()
        {
            return new();
        }
        public override Block Break()
        {
            return new BlockAir();
        }
    }
}
