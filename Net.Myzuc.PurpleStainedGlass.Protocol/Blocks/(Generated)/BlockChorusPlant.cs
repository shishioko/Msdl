namespace Net.Myzuc.PurpleStainedGlass.Protocol.Blocks
{
    public sealed class BlockChorusPlant : Block
    {
        private static (double xa, double ya, double za, double xb, double yb, double zb)[][] InternalCollisions = [
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125),
                (0, 0.1875, 0.1875, 0.1875, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0, 0.1875, 0.8125, 0.8125, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.8125),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875)
            ],
            [
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.8125),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0.1875, 0.1875, 0.1875, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0.1875, 0.1875, 0.8125, 0.8125, 1),
                (0.8125, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0.1875, 0.1875, 0.1875, 1, 0.8125, 0.8125),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0.1875, 0.1875, 1, 0.8125, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 1),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 1)
            ],
            [
                (0, 0.1875, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.1875)
            ],
            [
                (0.1875, 0.1875, 0, 0.8125, 0.8125, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0.1875, 0.1875, 0.1875, 0.8125, 0.8125, 1),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.1875, 0.8125, 0.8125, 0.8125, 1)
            ],
            [
                (0.1875, 0.1875, 0.1875, 0.8125, 0.8125, 1)
            ],
            [
                (0, 0.1875, 0.1875, 0.8125, 0.8125, 0.8125),
                (0.1875, 0.8125, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0.1875, 0.1875, 0.1875, 0.8125, 1, 0.8125)
            ],
            [
                (0, 0.1875, 0.1875, 0.8125, 0.8125, 0.8125)
            ],
            [
                (0.1875, 0.1875, 0.1875, 0.8125, 0.8125, 0.8125)
            ]
        ];
        public override int BlockId => 12340 + (West ? 0 : 1) + (Up ? 0 : 2) + (South ? 0 : 4) + (North ? 0 : 8) + (East ? 0 : 16) + (Down ? 0 : 32);
        public override int LiquidId => 0;
        public override int LightEmission => 0;
        public override int LightFilter => 1;
        public override (double xa, double ya, double za, double xb, double yb, double zb)[] Collisions => [.. InternalCollisions[BlockId - 12340]];
        public bool West = false;
        public bool Up = false;
        public bool South = false;
        public bool North = false;
        public bool East = false;
        public bool Down = false;
        public BlockChorusPlant()
        {
            
        }
        public override BlockChorusPlant Clone()
        {
            return new()
            {
                West = West,
                Up = Up,
                South = South,
                North = North,
                East = East,
                Down = Down
            };
        }
        public override Block Break()
        {
            return new BlockAir();
        }
    }
}
