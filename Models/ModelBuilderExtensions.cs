using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Name = "Ação" },
                    new Category { Id = 2, Name = "Aventura" },
                    new Category { Id = 3, Name = "Estratégia" },
                    new Category { Id = 4, Name = "RPG" },
                    new Category { Id = 5, Name = "Esportes" }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product { Id = 1, CategoryId = 1, Name = "Assassin's Creed: Valhalla", Sku = "ACV-001", Price = 59.99m, IsAvailable = true },
                    new Product { Id = 2, CategoryId = 2, Name = "The Legend of Zelda: Breath of the Wild", Sku = "LOZ-BOTW-002", Price = 49.99m, IsAvailable = true },
                    new Product { Id = 3, CategoryId = 3, Name = "Starcraft II", Sku = "SC2-003", Price = 29.99m, IsAvailable = true },
                    new Product { Id = 4, CategoryId = 4, Name = "The Witcher 3: Wild Hunt", Sku = "TW3-004", Price = 39.99m, IsAvailable = true },
                    new Product { Id = 5, CategoryId = 5, Name = "FIFA 22", Sku = "FIFA22-005", Price = 54.99m, IsAvailable = true },
                    new Product { Id = 6, CategoryId = 1, Name = "Call of Duty: Warzone", Sku = "CODWZ-006", Price = 0m, IsAvailable = true },
                    new Product { Id = 7, CategoryId = 2, Name = "Uncharted 4: A Thief's End", Sku = "UC4-007", Price = 39.99m, IsAvailable = true },
                    new Product { Id = 8, CategoryId = 3, Name = "Civilization VI", Sku = "CIV6-008", Price = 44.99m, IsAvailable = true },
                    new Product { Id = 9, CategoryId = 4, Name = "Final Fantasy XV", Sku = "FFXV-009", Price = 49.99m, IsAvailable = true },
                    new Product { Id = 10, CategoryId = 5, Name = "NBA 2K22", Sku = "NBA2K22-010", Price = 59.99m, IsAvailable = true },
                    new Product { Id = 11, CategoryId = 1, Name = "Doom Eternal", Sku = "DOOM-011", Price = 39.99m, IsAvailable = true },
                    new Product { Id = 12, CategoryId = 2, Name = "Red Dead Redemption 2", Sku = "RDR2-012", Price = 49.99m, IsAvailable = true },
                    new Product { Id = 13, CategoryId = 3, Name = "Age of Empires IV", Sku = "AOE4-013", Price = 54.99m, IsAvailable = true },
                    new Product { Id = 14, CategoryId = 4, Name = "Persona 5", Sku = "P5-014", Price = 29.99m, IsAvailable = true },
                    new Product { Id = 15, CategoryId = 5, Name = "Madden NFL 22", Sku = "MADDEN22-015", Price = 49.99m, IsAvailable = true },
                    new Product { Id = 16, CategoryId = 1, Name = "Borderlands 3", Sku = "BL3-016", Price = 44.99m, IsAvailable = true },
                    new Product { Id = 17, CategoryId = 2, Name = "Horizon Zero Dawn", Sku = "HZD-017", Price = 39.99m, IsAvailable = true },
                    new Product { Id = 18, CategoryId = 3, Name = "Sid Meier's Civilization V", Sku = "CIV5-018", Price = 29.99m, IsAvailable = true },
                    new Product { Id = 19, CategoryId = 4, Name = "Kingdom Hearts III", Sku = "KH3-019", Price = 54.99m, IsAvailable = true },
                    new Product { Id = 20, CategoryId = 5, Name = "Rocket League", Sku = "RL-020", Price = 19.99m, IsAvailable = true },
                    new Product { Id = 21, CategoryId = 1, Name = "Rainbow Six Siege", Sku = "R6S-021", Price = 29.99m, IsAvailable = true },
                    new Product { Id = 22, CategoryId = 2, Name = "The Elder Scrolls V: Skyrim", Sku = "TESV-022", Price = 39.99m, IsAvailable = true },
                    new Product { Id = 23, CategoryId = 3, Name = "Total War: Three Kingdoms", Sku = "TWTK-023", Price = 49.99m, IsAvailable = true },
                    new Product { Id = 24, CategoryId = 4, Name = "Mass Effect: Legendary Edition", Sku = "MELE-024", Price = 59.99m, IsAvailable = true },
                    new Product { Id = 25, CategoryId = 5, Name = "F1 2021", Sku = "F12021-025", Price = 54.99m, IsAvailable = true },
                    new Product { Id = 26, CategoryId = 1, Name = "Destiny 2", Sku = "DESTINY2-026", Price = 0m, IsAvailable = true },
                    new Product { Id = 27, CategoryId = 2, Name = "Genshin Impact", Sku = "GENSHIN-027", Price = 0m, IsAvailable = true },
                    new Product { Id = 28, CategoryId = 3, Name = "Stellaris", Sku = "STELLARIS-028", Price = 39.99m, IsAvailable = true },
                    new Product { Id = 29, CategoryId = 4, Name = "Diablo III", Sku = "DIABLO3-029", Price = 29.99m, IsAvailable = true },
                    new Product { Id = 30, CategoryId = 5, Name = "WWE 2K22", Sku = "WWE2K22-030", Price = 49.99m, IsAvailable = true }
                );

        }
    }
    }
