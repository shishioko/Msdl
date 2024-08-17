namespace Net.Myzuc.PurpleStainedGlass.Protocol.Blocks
{
    public sealed class BlockLoom : Block
    {
        public enum EnumFacing : int
        {
            North = 0,
            South = 1,
            West = 2,
            East = 3
        }
        public override int BlockId => 18404 + (int)Facing * 1;
        public override int LiquidId => 0;
        public override int LightEmission => 0;
        public override int LightFilter => 15;
        public override (double xa, double ya, double za, double xb, double yb, double zb)[] Collisions => [
            (0, 0, 0, 1, 1, 1)
        ];
        public EnumFacing Facing = EnumFacing.North;
        public BlockLoom()
        {
            
        }
        public override BlockLoom Clone()
        {
            return new()
            {
                Facing = Facing
            };
        }
        public override Block Break()
        {
            return new BlockAir();
        }
    }
}
