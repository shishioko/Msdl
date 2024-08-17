namespace Net.Myzuc.PurpleStainedGlass.Protocol.Blocks
{
    public sealed class BlockLightGrayStainedGlassPane : Block
    {
        private static (double xa, double ya, double za, double xb, double yb, double zb)[][] InternalCollisions = [
            [
                (0, 0, 0.4375, 1, 1, 0.5625),
                (0.4375, 0, 0, 0.5625, 1, 0.4375),
                (0.4375, 0, 0.5625, 0.5625, 1, 1)
            ],
            [
                (0.4375, 0, 0, 0.5625, 1, 1),
                (0.5625, 0, 0.4375, 1, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 1, 1, 0.5625),
                (0.4375, 0, 0, 0.5625, 1, 0.4375),
                (0.4375, 0, 0.5625, 0.5625, 1, 1)
            ],
            [
                (0.4375, 0, 0, 0.5625, 1, 1),
                (0.5625, 0, 0.4375, 1, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 1, 1, 0.5625),
                (0.4375, 0, 0, 0.5625, 1, 0.4375)
            ],
            [
                (0.4375, 0, 0, 0.5625, 1, 0.5625),
                (0.5625, 0, 0.4375, 1, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 1, 1, 0.5625),
                (0.4375, 0, 0, 0.5625, 1, 0.4375)
            ],
            [
                (0.4375, 0, 0, 0.5625, 1, 0.5625),
                (0.5625, 0, 0.4375, 1, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 1, 1, 0.5625),
                (0.4375, 0, 0.5625, 0.5625, 1, 1)
            ],
            [
                (0.4375, 0, 0.4375, 0.5625, 1, 1),
                (0.5625, 0, 0.4375, 1, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 1, 1, 0.5625),
                (0.4375, 0, 0.5625, 0.5625, 1, 1)
            ],
            [
                (0.4375, 0, 0.4375, 0.5625, 1, 1),
                (0.5625, 0, 0.4375, 1, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 1, 1, 0.5625)
            ],
            [
                (0.4375, 0, 0.4375, 1, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 1, 1, 0.5625)
            ],
            [
                (0.4375, 0, 0.4375, 1, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 0.5625, 1, 0.5625),
                (0.4375, 0, 0, 0.5625, 1, 0.4375),
                (0.4375, 0, 0.5625, 0.5625, 1, 1)
            ],
            [
                (0.4375, 0, 0, 0.5625, 1, 1)
            ],
            [
                (0, 0, 0.4375, 0.5625, 1, 0.5625),
                (0.4375, 0, 0, 0.5625, 1, 0.4375),
                (0.4375, 0, 0.5625, 0.5625, 1, 1)
            ],
            [
                (0.4375, 0, 0, 0.5625, 1, 1)
            ],
            [
                (0, 0, 0.4375, 0.5625, 1, 0.5625),
                (0.4375, 0, 0, 0.5625, 1, 0.4375)
            ],
            [
                (0.4375, 0, 0, 0.5625, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 0.5625, 1, 0.5625),
                (0.4375, 0, 0, 0.5625, 1, 0.4375)
            ],
            [
                (0.4375, 0, 0, 0.5625, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 0.5625, 1, 0.5625),
                (0.4375, 0, 0.5625, 0.5625, 1, 1)
            ],
            [
                (0.4375, 0, 0.4375, 0.5625, 1, 1)
            ],
            [
                (0, 0, 0.4375, 0.5625, 1, 0.5625),
                (0.4375, 0, 0.5625, 0.5625, 1, 1)
            ],
            [
                (0.4375, 0, 0.4375, 0.5625, 1, 1)
            ],
            [
                (0, 0, 0.4375, 0.5625, 1, 0.5625)
            ],
            [
                (0.4375, 0, 0.4375, 0.5625, 1, 0.5625)
            ],
            [
                (0, 0, 0.4375, 0.5625, 1, 0.5625)
            ],
            [
                (0.4375, 0, 0.4375, 0.5625, 1, 0.5625)
            ]
        ];
        public override int BlockId => 9628 + (West ? 0 : 1) + (Waterlogged ? 0 : 2) + (South ? 0 : 4) + (North ? 0 : 8) + (East ? 0 : 16);
        public override int LiquidId => Waterlogged ? 1 : 0;
        public override int LightEmission => 0;
        public override int LightFilter => 0;
        public override (double xa, double ya, double za, double xb, double yb, double zb)[] Collisions => [.. InternalCollisions[BlockId - 9628]];
        public bool West = false;
        public bool Waterlogged = false;
        public bool South = false;
        public bool North = false;
        public bool East = false;
        public BlockLightGrayStainedGlassPane()
        {
            
        }
        public override BlockLightGrayStainedGlassPane Clone()
        {
            return new()
            {
                West = West,
                Waterlogged = Waterlogged,
                South = South,
                North = North,
                East = East
            };
        }
        public override Block Break()
        {
            return Waterlogged ? new BlockWater() : new BlockAir();
        }
    }
}