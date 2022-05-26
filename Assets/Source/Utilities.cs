using System;

namespace DungeonCrawl
{
    public enum Direction : byte
    {
        Up,
        Down,
        Left,
        Right,
        UpRight,
        UpLeft,
        DownLeft,
        DownRight
    }

    public static class Utilities
    {
        public static (int x, int y) ToVector(this Direction dir)
        {
            switch (dir)
            {
                case Direction.Up:
                    return (0, 1);
                case Direction.Down:
                    return (0, -1);
                case Direction.Left:
                    return (-1, 0);
                case Direction.Right:
                    return (1, 0);
                case Direction.UpRight:
                    return (1, 1);
                case Direction.UpLeft:
                    return (-1, 1);
                case Direction.DownLeft:
                    return (-1, -1);
                case Direction.DownRight:
                    return (1, -1);
                default:
                    throw new ArgumentOutOfRangeException(nameof(dir), dir, null);
            }
        }
    }
}
