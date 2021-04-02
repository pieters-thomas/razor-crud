using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace razor_crud.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CharacterContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<CharacterContext>>()))
            {
                // Look for any Characters.
                if (!context.Character.Any())
                {
                    context.Character.AddRange(
                        new Character
                        {
                            Name = "Grog Strongjaw",
                            FirstAdventure = DateTime.Parse("2015-03-12"),
                            Coin = 5.00M,
                            Class = "Barbarian",
                            Level = 20
                        },
                        new Character
                        {
                            Name = "Vax'ildan",
                            FirstAdventure = DateTime.Parse("2015-03-12"),
                            Coin = 35.00M,
                            Class = "Rogue",
                            Level = 20
                        },
                        new Character
                        {
                            Name = "Vex'ildan",
                            FirstAdventure = DateTime.Parse("2015-03-12"),
                            Coin = 99.00M,
                            Class = "Ranger",
                            Level = 20
                        },
                        new Character
                        {
                            Name = "Percival de  Rolo",
                            FirstAdventure = DateTime.Parse("2015-03-12"),
                            Coin = 75.00M,
                            Class = "Fighter",
                            Level = 20
                        },
                        new Character
                        {
                            Name = "Pike Trickfoot",
                            FirstAdventure = DateTime.Parse("2015-03-12"),
                            Coin = 55.00M,
                            Class = "Cleric",
                            Level = 20
                        }
                    );
                    context.SaveChanges();
                }
            }

            using (var context = new razor_crudMonsterContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<razor_crudMonsterContext>>()))
            {
                // Look for any movies.
                if (!context.Monster.Any())
                {
                    context.Monster.AddRange(
                        new Monster
                        {
                            Name = "Ancient Red Dragon",
                            Type = "Dragon",
                            CR = 24,
                            Source = "MM"
                        },
                        new Monster
                        {
                            Name = "Beholder",
                            Type = "Aberration",
                            CR = 13,
                            Source = "MM"
                        },
                        new Monster
                        {
                            Name = "Lich",
                            Type = "Undead",
                            CR = 21,
                            Source = "MM"
                        }
                    );
                    context.SaveChanges();
                }
            }

            using (var context = new razor_crudMonsterContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<razor_crudMonsterContext>>()))
            {
                // Look for any movies.
                if (!context.Monster.Any())
                {
                    context.Monster.AddRange(
                        new Monster
                        {
                            Name = "Ancient Red Dragon",
                            Type = "Dragon",
                            CR = 24,
                            Source = "MM"
                        },
                        new Monster
                        {
                            Name = "Beholder",
                            Type = "Aberration",
                            CR = 13,
                            Source = "MM"
                        },
                        new Monster
                        {
                            Name = "Lich",
                            Type = "Undead",
                            CR = 21,
                            Source = "MM"
                        }
                    );
                    context.SaveChanges();
                }
            }

            using (var context = new razor_crudSpellContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<razor_crudSpellContext>>()))
            {
                // Look for any movies.
                if (context.Spell.Any())
                {
                    return;
                }

                context.Spell.AddRange(
                    new Spell
                    {
                        SpellName = "Wish",
                        SpellSlot = 9,
                        Concentration = false,
                        Components = ""
                    },
                    
                    new Spell
                    {
                        SpellName = "Fireball",
                        SpellSlot = 3,
                        Concentration = false,
                        Components = "Guano"
                    },
                    
                    new Spell
                    {
                        SpellName = "Bane",
                        SpellSlot = 1,
                        Concentration = true,
                        Components = "Blood"
                    }
                   
                );
                context.SaveChanges();
            }
        }
    }
}