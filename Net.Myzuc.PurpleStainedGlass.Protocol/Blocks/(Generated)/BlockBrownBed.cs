namespace Net.Myzuc.PurpleStainedGlass.Protocol.Blocks
{
    public sealed class BlockBrownBed : Block
    {
        public enum EnumPart : int
        {
            Head = 0,
            Foot = 1
        }
        public enum EnumFacing : int
        {
            North = 0,
            South = 1,
            West = 2,
            East = 3
        }
        private static (double xa, double ya, double za, double xb, double yb, double zb)[][] InternalCollisions = [
            [
                (0, 0, 0, 0.1875, 0.5625, 0.1875),
                (0.8125, 0, 0, 1, 0.5625, 0.1875),
                (0, 0.1875, 0.1875, 1, 0.5625, 1),
                (0.1875, 0.1875, 0, 0.8125, 0.5625, 0.1875)
            ],
            [
                (0, 0, 0.8125, 0.1875, 0.5625, 1),
                (0.8125, 0, 0.8125, 1, 0.5625, 1),
                (0, 0.1875, 0, 1, 0.5625, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.5625, 1)
            ],
            [
                (0, 0, 0, 0.1875, 0.5625, 0.1875),
                (0.8125, 0, 0, 1, 0.5625, 0.1875),
                (0, 0.1875, 0.1875, 1, 0.5625, 1),
                (0.1875, 0.1875, 0, 0.8125, 0.5625, 0.1875)
            ],
            [
                (0, 0, 0.8125, 0.1875, 0.5625, 1),
                (0.8125, 0, 0.8125, 1, 0.5625, 1),
                (0, 0.1875, 0, 1, 0.5625, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.5625, 1)
            ],
            [
                (0, 0, 0.8125, 0.1875, 0.5625, 1),
                (0.8125, 0, 0.8125, 1, 0.5625, 1),
                (0, 0.1875, 0, 1, 0.5625, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.5625, 1)
            ],
            [
                (0, 0, 0, 0.1875, 0.5625, 0.1875),
                (0.8125, 0, 0, 1, 0.5625, 0.1875),
                (0, 0.1875, 0.1875, 1, 0.5625, 1),
                (0.1875, 0.1875, 0, 0.8125, 0.5625, 0.1875)
            ],
            [
                (0, 0, 0.8125, 0.1875, 0.5625, 1),
                (0.8125, 0, 0.8125, 1, 0.5625, 1),
                (0, 0.1875, 0, 1, 0.5625, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.5625, 1)
            ],
            [
                (0, 0, 0, 0.1875, 0.5625, 0.1875),
                (0.8125, 0, 0, 1, 0.5625, 0.1875),
                (0, 0.1875, 0.1875, 1, 0.5625, 1),
                (0.1875, 0.1875, 0, 0.8125, 0.5625, 0.1875)
            ],
            [
                (0, 0, 0, 0.1875, 0.5625, 0.1875),
                (0, 0, 0.8125, 0.1875, 0.5625, 1),
                (0, 0.1875, 0.1875, 1, 0.5625, 0.8125),
                (0.1875, 0.1875, 0, 1, 0.5625, 0.1875),
                (0.1875, 0.1875, 0.8125, 1, 0.5625, 1)
            ],
            [
                (0.8125, 0, 0, 1, 0.5625, 0.1875),
                (0.8125, 0, 0.8125, 1, 0.5625, 1),
                (0, 0.1875, 0, 0.8125, 0.5625, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.5625, 0.8125)
            ],
            [
                (0, 0, 0, 0.1875, 0.5625, 0.1875),
                (0, 0, 0.8125, 0.1875, 0.5625, 1),
                (0, 0.1875, 0.1875, 1, 0.5625, 0.8125),
                (0.1875, 0.1875, 0, 1, 0.5625, 0.1875),
                (0.1875, 0.1875, 0.8125, 1, 0.5625, 1)
            ],
            [
                (0.8125, 0, 0, 1, 0.5625, 0.1875),
                (0.8125, 0, 0.8125, 1, 0.5625, 1),
                (0, 0.1875, 0, 0.8125, 0.5625, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.5625, 0.8125)
            ],
            [
                (0.8125, 0, 0, 1, 0.5625, 0.1875),
                (0.8125, 0, 0.8125, 1, 0.5625, 1),
                (0, 0.1875, 0, 0.8125, 0.5625, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.5625, 0.8125)
            ],
            [
                (0, 0, 0, 0.1875, 0.5625, 0.1875),
                (0, 0, 0.8125, 0.1875, 0.5625, 1),
                (0, 0.1875, 0.1875, 1, 0.5625, 0.8125),
                (0.1875, 0.1875, 0, 1, 0.5625, 0.1875),
                (0.1875, 0.1875, 0.8125, 1, 0.5625, 1)
            ],
            [
                (0.8125, 0, 0, 1, 0.5625, 0.1875),
                (0.8125, 0, 0.8125, 1, 0.5625, 1),
                (0, 0.1875, 0, 0.8125, 0.5625, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.5625, 0.8125)
            ],
            [
                (0, 0, 0, 0.1875, 0.5625, 0.1875),
                (0, 0, 0.8125, 0.1875, 0.5625, 1),
                (0, 0.1875, 0.1875, 1, 0.5625, 0.8125),
                (0.1875, 0.1875, 0, 1, 0.5625, 0.1875),
                (0.1875, 0.1875, 0.8125, 1, 0.5625, 1)
            ]
        ];
        public override int BlockId => 1880 + (int)Part * 1 + (Occupied ? 0 : 2) + (int)Facing * 4;
        public override int LiquidId => 0;
        public override int LightEmission => 0;
        public override int LightFilter => 0;
        public override (double xa, double ya, double za, double xb, double yb, double zb)[] Collisions => [.. InternalCollisions[BlockId - 1880]];
        public EnumPart Part = EnumPart.Head;
        public bool Occupied = false;
        public EnumFacing Facing = EnumFacing.North;
        public BlockBrownBed()
        {
            
        }
        public override BlockBrownBed Clone()
        {
            return new()
            {
                Part = Part,
                Occupied = Occupied,
                Facing = Facing
            };
        }
        public override Block Break()
        {
            return new BlockAir();
        }
    }
}
