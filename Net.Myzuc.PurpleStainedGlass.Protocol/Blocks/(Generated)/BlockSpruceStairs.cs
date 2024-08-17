namespace Net.Myzuc.PurpleStainedGlass.Protocol.Blocks
{
    public sealed class BlockSpruceStairs : Block
    {
        public enum EnumShape : int
        {
            Straight = 0,
            InnerLeft = 1,
            InnerRight = 2,
            OuterLeft = 3,
            OuterRight = 4
        }
        public enum EnumHalf : int
        {
            Top = 0,
            Bottom = 1
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
                (0, 0, 0, 1, 1, 0.5),
                (0, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 1, 0.5),
                (0, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 0.5, 1, 1),
                (0.5, 0, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 0.5, 1, 1),
                (0.5, 0, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 1, 0.5),
                (0.5, 0, 0.5, 1, 1, 1),
                (0, 0.5, 0.5, 0.5, 1, 1)
            ],
            [
                (0, 0, 0, 1, 1, 0.5),
                (0.5, 0, 0.5, 1, 1, 1),
                (0, 0.5, 0.5, 0.5, 1, 1)
            ],
            [
                (0, 0, 0, 0.5, 1, 0.5),
                (0, 0.5, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 0.5, 1, 0.5),
                (0, 0.5, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0.5, 0, 0, 1, 1, 0.5),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0.5, 0, 0, 1, 1, 0.5),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0.5, 1, 1, 1),
                (0, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0.5, 1, 1, 1),
                (0, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0.5, 1, 1, 1),
                (0.5, 0, 0, 1, 1, 0.5),
                (0, 0.5, 0, 0.5, 1, 0.5)
            ],
            [
                (0, 0, 0.5, 1, 1, 1),
                (0.5, 0, 0, 1, 1, 0.5),
                (0, 0.5, 0, 0.5, 1, 0.5)
            ],
            [
                (0, 0, 0, 0.5, 1, 1),
                (0.5, 0, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 0.5, 1, 1),
                (0.5, 0, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0.5, 0, 0.5, 1, 1, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0.5, 0, 0.5, 1, 1, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0.5, 0.5, 1, 1),
                (0, 0.5, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0.5, 0.5, 1, 1),
                (0, 0.5, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0.5, 0.5, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0.5, 0.5, 1, 1)
            ],
            [
                (0, 0, 0, 0.5, 1, 1),
                (0.5, 0.5, 0, 1, 1, 1)
            ],
            [
                (0, 0, 0, 0.5, 1, 1),
                (0.5, 0.5, 0, 1, 1, 1)
            ],
            [
                (0, 0, 0, 0.5, 1, 1),
                (0.5, 0, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 0.5, 1, 1),
                (0.5, 0, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 0.5, 1, 1),
                (0.5, 0, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 0.5, 1, 1),
                (0.5, 0, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0.5, 0.5, 1, 1),
                (0, 0.5, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0.5, 0.5, 1, 1),
                (0, 0.5, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 0.5, 1, 0.5),
                (0, 0.5, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 0.5, 1, 0.5),
                (0, 0.5, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0.5, 0.5, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0.5, 0.5, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 0.5, 1, 0.5)
            ],
            [
                (0.5, 0, 0, 1, 1, 1),
                (0, 0.5, 0, 0.5, 1, 1)
            ],
            [
                (0.5, 0, 0, 1, 1, 1),
                (0, 0.5, 0, 0.5, 1, 1)
            ],
            [
                (0, 0, 0, 1, 1, 0.5),
                (0.5, 0, 0.5, 1, 1, 1),
                (0, 0.5, 0.5, 0.5, 1, 1)
            ],
            [
                (0, 0, 0, 1, 1, 0.5),
                (0.5, 0, 0.5, 1, 1, 1),
                (0, 0.5, 0.5, 0.5, 1, 1)
            ],
            [
                (0, 0, 0.5, 1, 1, 1),
                (0.5, 0, 0, 1, 1, 0.5),
                (0, 0.5, 0, 0.5, 1, 0.5)
            ],
            [
                (0, 0, 0.5, 1, 1, 1),
                (0.5, 0, 0, 1, 1, 0.5),
                (0, 0.5, 0, 0.5, 1, 0.5)
            ],
            [
                (0.5, 0, 0, 1, 1, 0.5),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0.5, 0, 0, 1, 1, 0.5),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0.5, 0, 0.5, 1, 1, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0.5, 0, 0.5, 1, 1, 1),
                (0, 0.5, 0, 0.5, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0.5, 0.5, 0, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0.5, 0.5, 0, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0, 1, 1, 0.5),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0, 0.5, 0.5, 1, 1, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0.5, 0.5, 0, 1, 1, 0.5)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ],
            [
                (0, 0, 0, 1, 0.5, 1),
                (0.5, 0.5, 0.5, 1, 1, 1)
            ]
        ];
        public override int BlockId => 7666 + (Waterlogged ? 0 : 1) + (int)Shape * 2 + (int)Half * 10 + (int)Facing * 20;
        public override int LiquidId => Waterlogged ? 1 : 0;
        public override int LightEmission => 0;
        public override int LightFilter => 0;
        public override (double xa, double ya, double za, double xb, double yb, double zb)[] Collisions => [.. InternalCollisions[BlockId - 7666]];
        public bool Waterlogged = false;
        public EnumShape Shape = EnumShape.Straight;
        public EnumHalf Half = EnumHalf.Top;
        public EnumFacing Facing = EnumFacing.North;
        public BlockSpruceStairs()
        {
            
        }
        public override BlockSpruceStairs Clone()
        {
            return new()
            {
                Waterlogged = Waterlogged,
                Shape = Shape,
                Half = Half,
                Facing = Facing
            };
        }
        public override Block Break()
        {
            return Waterlogged ? new BlockWater() : new BlockAir();
        }
    }
}
