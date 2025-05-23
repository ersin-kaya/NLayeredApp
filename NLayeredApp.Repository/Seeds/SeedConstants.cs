namespace NLayeredApp.Repository.Seeds;

public static class SeedConstants
{
    public static class Common
    {
        public static readonly DateTimeOffset CreatedAt = new(2023, 1, 1, 0, 0, 0, TimeSpan.Zero);
        public const string CreatedBy = "system";
        
        public const bool IsActive = true;
    }
    
    public enum CategoryIds
    {
        Electronics = 1,
        Clothing = 2,
        HomeAndLiving = 3
    }
    
    public enum FeatureTypeIds
    {
        Color = 1,
        Size = 2,
        Material = 3,
        Storage = 4,
        Memory = 5,
        Processor = 6,
        ScreenSize = 7
    }
    
    public static class FeatureIds
    {
        public static class Electronics
        {
            public enum ColorIds
            {
                Black = 1,
                White = 2,
                Silver = 3
            }
            
            public enum StorageIds
            {
                Gb64 = 4,
                Gb128 = 5,
                Gb256 = 6,
                Gb512 = 7
            }
            
            public enum MemoryIds
            {
                Gb4 = 8,
                Gb8 = 9,
                Gb16 = 10,
                Gb32 = 11
            }
            
            public enum ProcessorIds
            {
                AmdRyzen5_7600X = 12,
                AmdRyzen7_9800X3D = 13,
                AmdRyzen9_9950X3D = 14
            }
            
            public static class ScreenSizes
            {
                public const int Inch5_5 = 15;
                public const int Inch6_1 = 16;
                public const int Inch13_3 = 17;
                public const int Inch15_6 = 18;
                public const int Inch24 = 19;
                public const int Inch27 = 20;
            }
        }

        public static class Clothing
        {
            public static class Colors
            {
                public const int Red = 21;
                public const int Blue = 22;
                public const int Green = 23;
                public const int Yellow = 24;
            }
            
            public static class Sizes
            {
                public const int Xs = 25;
                public const int S = 26;
                public const int M = 27;
                public const int L = 28;
                public const int Xl = 29;
            }

            public static class Materials
            {
                public const int Cotton = 30;
                public const int Polyester = 31;
                public const int Wool = 32;
                public const int Denim = 33;
                public const int Silk = 34;
                public const int Leather = 35;
                public const int FauxLeather = 36;
                public const int Linen = 37;
                public const int Viscose = 38;
            }
        }

        public static class HomeAndLiving
        {
            public static class Colors
            {
                public const int Beige = 39;
                public const int White = 40;
                public const int Brown = 41;
                public const int Gray = 42;
            }
        
            public static class Materials
            {
                public const int Wood = 43;
                public const int Metal = 44;
                public const int Plastic = 45;
                public const int Glass = 46;
                public const int Ceramic = 47;
            } 
        }
    }
    
    public static class ProductIds
    {
        public const int GalaxyS25 = 1;
        public const int GalaxyS24 = 2;
        public const int LogitechMouse = 3;
        public const int LogitechKeyboard = 4;
        public const int LogitechHeadset = 5;
        public const int LogitechGamepad = 6;
        
        public const int PoloShirt = 7;
        public const int BlueDenimJean = 8;
        public const int RunningShoes = 9;
        
        public const int DiningTable = 10;
        public const int LedFloorLamp = 11;
        public const int Bookshelf = 12;
    }
}