namespace Net.Myzuc.PurpleStainedGlass.Protocol.Blocks
{
    public sealed class BlockStonePressurePlate : Block
    {
        public override int BlockId => 5650 + (Powered ? 0 : 1);
        public override int LiquidId => 0;
        public override int LightEmission => 0;
        public override int LightFilter => 0;
        public override (double xa, double ya, double za, double xb, double yb, double zb)[] Collisions => [];
        public bool Powered = false;
        public BlockStonePressurePlate()
        {
            
        }
        public override BlockStonePressurePlate Clone()
        {
            return new()
            {
                Powered = Powered
            };
        }
        public override Block Break()
        {
            return new BlockAir();
        }
    }
}
