namespace NLayeredApp.Repository.Seeds;

public static class SeedConstants
{
    public static class Common
    {
        public static readonly DateTimeOffset CreatedAt = new(2023, 1, 1, 0, 0, 0, TimeSpan.Zero);
        public const string CreatedBy = "system";
        
        public const bool IsActive = true;
        public const bool IsRequired = true;
        public const bool IsNotRequired = false;
    }
    
    public enum Category
    {
        Electronics = 1,
        Clothing = 2,
        HomeAndLiving = 3
    }
    
    public enum FeatureType
    {
        Color = 1,
        Size = 2,
        Material = 3,
        Storage = 4,
        Ram = 5,
        Processor = 6,
        ScreenSize = 7
    }
    
    public static class Features
    {
        public static class ElectronicsColors
        {
            public const int Black = 1;
            public const int White = 2;
            public const int Silver = 3;
        }
            
        public static class StorageOptions
        {
            public const int Gb64 = 4;
            public const int Gb128 = 5;
            public const int Gb256 = 6;
            public const int Gb512 = 7;
        }
            
        public static class MemoryOptions
        {
            public const int Gb4 = 8;
            public const int Gb8 = 9;
            public const int Gb16 = 10;
            public const int Gb32 = 11;
        }
            
        public static class ClothingColors
        {
            public const int Red = 12;
            public const int Blue = 13;
            public const int Green = 14;
            public const int Yellow = 15;
        }
            
        public static class ClothingSizes
        {
            public const int Xs = 16;
            public const int S = 17;
            public const int M = 18;
            public const int L = 19;
            public const int Xl = 20;
        }
    }
    
    public static class Products
    {
        public const int GalaxyS25 = 1;
        public const int GalaxyS24 = 2;
        public const int PoloShirt = 3;
        public const int DenimJeans = 4;
        public const int SportsShoes = 5;
    }
}