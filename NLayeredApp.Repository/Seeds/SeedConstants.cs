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
            
            public enum ScreenSizeIds
            {
                Inch5_5 = 15,
                Inch6_1 = 16,
                Inch13_3 = 17,
                Inch15_6 = 18,
                Inch24 = 19,
                Inch27 = 20
            }
        }

        public static class Clothing
        {
            public enum ColorIds
            {
                Red = 21,
                Blue = 22,
                Green = 23,
                Yellow = 24
            }
            
            public enum SizeIds
            {
                Xs = 25,
                S = 26,
                M = 27,
                L = 28,
                Xl = 29
            }

            public enum MaterialIds
            {
                Cotton = 30,
                Polyester = 31,
                Wool = 32,
                Denim = 33,
                Silk = 34,
                Leather = 35,
                FauxLeather = 36,
                Linen = 37,
                Viscose = 38
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