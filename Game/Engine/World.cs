using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Spell> Spells = new List<Spell>();
        public static readonly List<Buff> Buffs = new List<Buff>();
        public static readonly List<Race> Races = new List<Race>();

        #region KONSTANTER
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_LEGENDARY_SWORD = 11;
        public const int ITEM_ID_MAGICAL_BOW = 12;
        public const int ITEM_ID_IRON_SWORD = 18;

        public const int ITEM_ID_CLOTH_ARMOUR = 16;
        public const int ITEM_ID_METAL_ARMOUR = 17;

        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_DRAGON_SKULL = 13;
        public const int ITEM_ID_DEATHCLAW_HAND = 14;
        
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_ADVANCED_HEALING_POTION = 15;
        
        public const int ITEM_ID_ADVENTURER_PASS = 10;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_DRAGON = 4;
        public const int MONSTER_ID_MAGICAN = 5;
        public const int MONSTER_ID_DEATHCLAW = 6;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_HIDDEN_TREASURE = 3;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;

        public const int SPELL_EFFECT_ID_DAMAGE = 1;
        public const int SPELL_EFFECT_ID_HEAL = 2;
        public const int SPELL_EFFECT_ID_RAISE_HP = 3;
        public const int SPELL_EFFECT_ID_RAISE_STRENGTH = 4;
        public const int SPELL_EFFECT_ID_RESTORE_MANA = 5;
        public const int SPELL_EFFECT_ID_TELEPORT = 6;
        public const int SPELL_EFFECT_ID_INVISIBLE = 7;

        public const int SPELL_ID_FIREBALL = 1;
        public const int SPELL_ID_FROSTICE = 2;
        public const int SPELL_ID_TELEPORT = 3;
        public const int SPELL_ID_ENDURANCE = 4;
        public const int SPELL_ID_HOLY_NOVA = 5;
        public const int SPELL_ID_RESTORE_HEALTH = 6;
        public const int SPELL_ID_RESTORE_MANA = 7;

        public const int BUFF_ID_INCREASE_MAX_HP = 1;
        public const int BUFF_ID_INCREASE_STR = 2;
        public const int BUFF_ID_INCREASE_DEX = 3;
        public const int BUFF_ID_INCREASE_INT = 4;
        public const int BUFF_ID_INCREASE_MAX_MANA = 5;

        public const int RACE_ID_HUNMAN = 1;
        public const int RACE_ID_ELF = 2;
        public const int RACE_ID_ORC = 3;
        public const int RACE_ID_GOBLIN = 4;
        public const int RACE_ID_DWARF = 5;
        public const int RACE_ID_MONSTER = 6;
        public const int RACE_ID_ANIMAL = 7;
        #endregion

        static World()
        {
            PopulateRaces();
            PopulateItems();
            PopulateBuffs();
            PopulateSpells();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateRaces()
        {
            Races.Add(new Race(RACE_ID_HUNMAN, "Människa", "Människor är intelligenta men naiva."));
            Races.Add(new Race(RACE_ID_ELF,"Alv","Alver är bra på magi och fingerärdighet"));
            Races.Add(new Race(RACE_ID_GOBLIN, "Goblin", "En Goblin är fysiskt större men mindre intelligenta."));
            Races.Add(new Race(RACE_ID_ORC, "Orch", "Starka och kan hålla ut i strid som ingen annan."));
            Races.Add(new Race(RACE_ID_DWARF, "Dvärg", "En dvärg må vara liten, men vissa är dem bästa bågskyttarna i världen."));
            Races.Add(new Race(RACE_ID_MONSTER,"Monster","Vissa monsters kan vara riktigt farliga"));
            Races.Add(new Race(RACE_ID_ANIMAL, "Djur", "Alla djur går inte att äta"));
        }

        private static void PopulateBuffs()
        {
            Buffs.Add(new Buff(BUFF_ID_INCREASE_MAX_HP, "Uthållighet", "Ökar dina maximala slagpoäng"));
            Buffs.Add(new Buff(BUFF_ID_INCREASE_DEX, "Fingerfärdighet Upp", "Ökar din nivå i fingerfärdighet"));
            Buffs.Add(new Buff(BUFF_ID_INCREASE_INT, "Intelligent Upp", "Ökar din intelligensnivå"));
        }

        private static void PopulateSpells()
        {
            Spells.Add(new Spell(SPELL_ID_FIREBALL, "Eldklot", 5, SPELL_EFFECT_ID_DAMAGE, 15, true));
            Spells.Add(new Spell(SPELL_ID_FROSTICE, "Isklot", 5, SPELL_EFFECT_ID_DAMAGE, 15, true));
            Spells.Add(new Spell(SPELL_ID_HOLY_NOVA, "Holy Nova", 50, SPELL_EFFECT_ID_DAMAGE, 100, true));
            Spells.Add(new Spell(SPELL_ID_RESTORE_HEALTH, "Hela", 10, SPELL_EFFECT_ID_HEAL, 10, true));
            Spells.Add(new Spell(SPELL_ID_RESTORE_MANA, "Återställ Mana", 0, SPELL_EFFECT_ID_RESTORE_MANA, 20, true));
            Spells.Add(new Spell(SPELL_ID_ENDURANCE, "Uthållighet", 30, SPELL_EFFECT_ID_RAISE_HP, 100, false));
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rostigt svärd", "Rostiga svärd", 0, 5)); 
            Items.Add(new Weapon(ITEM_ID_MAGICAL_BOW, "Magisk båge", "Magiska bågar", 5, 10));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Klubba", "Klubbor", 3, 10));
            Items.Add(new Weapon(ITEM_ID_IRON_SWORD, "Stålsvärd", "Stålsvärd", 3, 7));
            Items.Add(new Weapon(ITEM_ID_LEGENDARY_SWORD, "Legendarens svärd", "Legendarens svärd", 50, 100));
            Items.Add(new Armour(ITEM_ID_CLOTH_ARMOUR, "Tygskydd", "Tygskydd", 5, 0));
            Items.Add(new Armour(ITEM_ID_METAL_ARMOUR, "Metallpansar", "Metallpansar", 20, 10));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Råttsvans", "Råttsvansar"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Pälsbit", "Pälsbitar"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Huggtand från orm", "Huggtänder från ormar"));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Ormskinn", "Ormskinn"));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Huggtand från spindel", "Huggtänder från ormar"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spindelväv", "Spindelvävar"));
            Items.Add(new Item(ITEM_ID_DEATHCLAW_HAND, "Deathclaw hand", "Deathclaw hands"));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Hälsodryck", "Hälsodrycker", 5)); // ID NAME PLURAL NAME, AMOUNT TO HEAL
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Äventyrspassage", "Äventyrspassager"));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Råtta", 5, 3, 10, 3, 3,1,2,5,1,0,0,RaceByID(RACE_ID_ANIMAL));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Orm", 5, 3, 10, 5, 5,1,1,5,1,0,0,RaceByID(RACE_ID_ANIMAL));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Jättespindel", 20, 5, 40, 10, 10,7,7,2,4,10,10,RaceByID(RACE_ID_MONSTER),(Armour)ItemByID(ITEM_ID_METAL_ARMOUR));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monster dragon = new Monster(MONSTER_ID_DRAGON, "Drake", 30, 100, 100, 75, 75,10,10,10,8,50,50,RaceByID(RACE_ID_MONSTER));
            dragon.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DRAGON_SKULL), 100, true));
            
            Monster magican = new Monster(MONSTER_ID_MAGICAN, "Trollkarl", 5, 50, 150, 35, 35,5,2,2,10,500,500,RaceByID(RACE_ID_ELF),(Armour)ItemByID(ITEM_ID_CLOTH_ARMOUR));
            magican.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ADVANCED_HEALING_POTION), 75, true));
            magican.Spells.Add(new SpellList(SpellByID(SPELL_ID_FIREBALL)));
            magican.Spells.Add(new SpellList(SpellByID(SPELL_ID_FROSTICE)));

            Monster deathclaw = new Monster(MONSTER_ID_DEATHCLAW, "Deathclaw", 250, 500, 1000, 250, 250,25,15,15,5,0,0,RaceByID(RACE_ID_MONSTER));
            deathclaw.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DEATHCLAW_HAND), 100, true));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
            Monsters.Add(magican);
            Monsters.Add(dragon);
            Monsters.Add(deathclaw);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden =
                new Quest(
                    QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Rensa upp alkemistens trädgård",
                    "Döda råttorna i alkemistens trädgård och samla in 3 råttsvansar. Du kommer få en hälsodryck och 10 guldpengar.", 20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearFarmersField =
                new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Rensa upp bondens åker",
                    "Döda ormarna på bondens åker och ta tillbaka tre ormhuggtänder. Du kommer att få tillgång till äventyrspassagen och 20 guldpengar.", 20, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));
            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKESKIN), 2));

            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);


            Quest findTheHiddenTreasure =
                new Quest(
                    QUEST_ID_HIDDEN_TREASURE,
                    "Hitta skattkistan",
                    "Det går rykten om att det finns en gömd skatt här, jag måste hitta den!",
                    30,
                    100,
                    ItemByID(ITEM_ID_LEGENDARY_SWORD));
            findTheHiddenTreasure.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_DEATHCLAW_HAND), 1));

            
            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
            Quests.Add(findTheHiddenTreasure);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Hemma", "Ditt hus. Här bor du.");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Stadstorget", "Du ser en stor fontän.");

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alkemistens skjul.", "Många skumma plantor här.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alkemistens trädgård", "Väldigt mycket växer här.");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Bondgården", "Det finns ett litet torpahus, det står en bonde framför.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Bondens åker", "Du ser mängder med sädeslag som växer här.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Vaktposten", "Det står en stor, läskig vakt här.", ItemByID(ITEM_ID_ADVENTURER_PASS));
            guardPost.MonsterLivingHere = MonsterByID(MONSTER_ID_MAGICAN);

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bron", "En stenbro korsar floden");
            bridge.QuestAvailableHere = QuestByID(QUEST_ID_HIDDEN_TREASURE);

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Skogen", "Spindelväv täcker trädtopparna.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);
            spiderField.LevelRequirement = 5;

            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            // Lägg till platserna i statiska listan
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static Spell SpellByID(int id)
        {
            foreach (Spell spell in Spells)
            {
                if (spell.ID == id)
                    return spell;
            }
            return null;
        }
        public static Race RaceByID(int id)
        {
            foreach(Race race in Races)
            {
                if (race.ID == id)
                    return race;
            }
            return null;
        }
        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }
        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }
        public static Buff BuffByID(int id)
        {
            foreach(Buff buff in Buffs)
            {
                if (buff.ID == id)
                {
                    return buff;
                }
            }
            return null;
        }
        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}
