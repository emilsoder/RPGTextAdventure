using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ComponentModel;
namespace Engine
{
   public class Player : LivingCreature
    {
        private int _gold, _experincePoints;
        public int Gold
        {
            get
            {
                return _gold;
            }

            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }

        }
        public int ExperiencePoints
        {
            get { return _experincePoints; } 

            set { _experincePoints = value;
                OnPropertyChanged("ExperiencePoints");
            }
        }

        public BindingList<InventoryItem> Inventory { get; set; }
        public BindingList<PlayerQuest> Quests { get; set; }
        public Location CurrentLocation { get; set; }
        public Weapon CurrentWeapon { get; set; }
        public HealingPotion CurrentPotion { get; set; }
        public List<Weapon> Weapons
       {
           get { return Inventory.Where(x => x.Details is Weapon).Select(x => x.Details as Weapon).ToList(); }
       }
        public List<HealingPotion> Potions
       {
           get { return Inventory.Where(x => x.Details is HealingPotion).Select(x => x.Details as HealingPotion).ToList(); }
       }

        public Player(int currentHitPoints, int maximumHitPoints, int gold, int experiencePoints, int level, int strength, int dexterity, int intelligent, int currentMana, int maximumMana,Race race, Armour armourUsed = null) : base(currentHitPoints, maximumHitPoints, level,strength, dexterity, intelligent, currentMana, maximumMana, race, armourUsed)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Inventory = new BindingList<InventoryItem>();
            Quests = new BindingList<PlayerQuest>();
        }

        public static Player LoadPlayerInformationFromXml(string xmlPlayerData)
        {
            Player player;
            try
            {
                XmlDocument playerData = new XmlDocument();
                playerData.LoadXml(xmlPlayerData);

                int currentHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentHitPoints").InnerText);
                int maximumHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaximumHitPoints").InnerText);
                int gold = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Gold").InnerText);
                int experiencePoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/ExperiencePoints").InnerText);
                int level = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Level").InnerText);
                int strength = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Strength").InnerText);
                int dexterity = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Dexterity").InnerText);
                int intelligent = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Intelligent").InnerText);
                int currentMana = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentMana").InnerText);
                int maximumMana = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaximumMana").InnerText);
                Race race = World.RaceByID(Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Race").InnerText));
                Armour armourUsed = null;

                if (Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/ArmourUsed").InnerText) != 0)
                {
                    armourUsed = (Armour)World.ItemByID(Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/ArmourUsed").InnerText));
                }
                player = new Player(currentHitPoints,maximumHitPoints,gold,experiencePoints,level,strength,dexterity,intelligent,currentMana,maximumMana,race,armourUsed);
                player.CurrentLocation = World.LocationByID(Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentLocation").InnerText));
                if (Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText) != 0)
                    player.CurrentWeapon = (Weapon)World.ItemByID(Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText));
                else
                    player.CurrentWeapon = null;
                if (Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentPotion").InnerText) != 0)
                    player.CurrentPotion = (HealingPotion)World.ItemByID(Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentPotion").InnerText));
                else
                    player.CurrentPotion = null;
                foreach (XmlNode node in playerData.SelectNodes("/Player/InventoryItems/InventoryItem"))
                {
                    player.AddItem(World.ItemByID(Convert.ToInt32(node.Attributes["ID"].Value)),Convert.ToInt32(node.Attributes["Quantity"].Value));
                }

                foreach (XmlNode node in playerData.SelectNodes("/Player/PlayerQuests/PlayerQuest"))
                {
                    PlayerQuest playerQuest = new PlayerQuest(World.QuestByID(Convert.ToInt32(node.Attributes["ID"].Value)));
                    playerQuest.IsCompleted = Convert.ToBoolean(node.Attributes["IsCompleted"].Value);
                    player.Quests.Add(playerQuest);
                }
            }
            catch
            {
               player = new Player(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, World.RaceByID(World.RACE_ID_HUNMAN));
            }
            return player;
        }

        public string toXmlString()
        {
            XmlDocument playerData = new XmlDocument();
            XmlNode player = playerData.CreateElement("Player");
            playerData.AppendChild(player);
            XmlNode stats = playerData.CreateElement("Stats");
            player.AppendChild(stats);

            // Nuvarande slagpoäng
            XmlNode currentHitPoints = playerData.CreateElement("CurrentHitPoints");
            currentHitPoints.AppendChild(playerData.CreateTextNode(CurrentHitPoints.ToString()));
            stats.AppendChild(currentHitPoints);

            // Maximala slagpoäng
            XmlNode maximumHitPoints = playerData.CreateElement("MaximumHitPoints");
            maximumHitPoints.AppendChild(playerData.CreateTextNode(MaximumHitPoints.ToString()));
            stats.AppendChild(maximumHitPoints);

            // Guld
            XmlNode gold = playerData.CreateElement("Gold");
            gold.AppendChild(playerData.CreateTextNode(Gold.ToString()));
            stats.AppendChild(gold);

            // Erfarenhetspoäng
            XmlNode experincePoints = playerData.CreateElement("ExperiencePoints");
            experincePoints.AppendChild(playerData.CreateTextNode(ExperiencePoints.ToString()));
            stats.AppendChild(experincePoints);

            // Nuvarande platsposition
            XmlNode currentLocation = playerData.CreateElement("CurrentLocation");
            currentLocation.AppendChild(playerData.CreateTextNode(CurrentLocation.ID.ToString()));
            stats.AppendChild(currentLocation);

            // Nivå
            XmlNode level = playerData.CreateElement("Level");
            level.AppendChild(playerData.CreateTextNode(Level.ToString()));
            stats.AppendChild(level);

            // Styrka
            XmlNode strength = playerData.CreateElement("Strength");
            strength.AppendChild(playerData.CreateTextNode(Strength.ToString()));
            stats.AppendChild(strength);

            // Fingerfärdighet 
            XmlNode dexterity = playerData.CreateElement("Dexterity");
            dexterity.AppendChild(playerData.CreateTextNode(Dexterity.ToString()));
            stats.AppendChild(dexterity);

            // Intelligens
            XmlNode intelligent = playerData.CreateElement("Intelligent");
            intelligent.AppendChild(playerData.CreateTextNode(Intelligent.ToString()));
            stats.AppendChild(intelligent);

            // Nuvarande Mana
            XmlNode currentMana = playerData.CreateElement("CurrentMana");
            currentMana.AppendChild(playerData.CreateTextNode(CurrentMana.ToString()));
            stats.AppendChild(currentMana);

            // Maximalt mana
            XmlNode maximumMana = playerData.CreateElement("MaximumMana");
            maximumMana.AppendChild(playerData.CreateTextNode(MaximumMana.ToString()));
            stats.AppendChild(maximumMana);

            //Ras
            XmlNode race = playerData.CreateElement("Race");
            race.AppendChild(playerData.CreateTextNode(CreatureRace.ID.ToString()));
            stats.AppendChild(race);

            // Använd pansar
            XmlNode armourUsed = playerData.CreateElement("ArmourUsed");
            if (ArmourUsed != null)
                armourUsed.AppendChild(playerData.CreateTextNode(ArmourUsed.ID.ToString()));
            else
                armourUsed.AppendChild(playerData.CreateTextNode("0"));
            stats.AppendChild(armourUsed);
           
            // Nuvarande vapen
            XmlNode currentWeapon = playerData.CreateElement("CurrentWeapon");
            if(CurrentWeapon != null)
                currentWeapon.AppendChild(playerData.CreateTextNode(CurrentWeapon.ID.ToString()));
            else
                currentWeapon.AppendChild(playerData.CreateTextNode("0"));
            stats.AppendChild(currentWeapon);

            // Potion
            XmlNode currentPotion = playerData.CreateElement("CurrentPotion");
            if (CurrentPotion != null)
                currentPotion.AppendChild(playerData.CreateTextNode(CurrentPotion.ID.ToString()));
            else
                currentPotion.AppendChild(playerData.CreateTextNode("0"));
            stats.AppendChild(currentPotion);

            //Inventarie
            XmlNode inventroyItems = playerData.CreateElement("InventoryItems");
            player.AppendChild(inventroyItems);

            foreach(InventoryItem item in Inventory)
            {
                XmlNode inventoryItem = playerData.CreateElement("InventoryItem");

                XmlAttribute idAttribute = playerData.CreateAttribute("ID");
                idAttribute.Value = item.Details.ID.ToString();
                inventoryItem.Attributes.Append(idAttribute);

                XmlAttribute quantityAttribute = playerData.CreateAttribute("Quantity");
                quantityAttribute.Value = item.Quantity.ToString();
                inventoryItem.Attributes.Append(quantityAttribute);

                inventroyItems.AppendChild(inventoryItem);
            }

             // Uppdrag
            XmlNode playerQuests = playerData.CreateElement("PlayerQuests");
            player.AppendChild(playerQuests);

            foreach(PlayerQuest quest in Quests)
            {
                XmlNode playerQuest = playerData.CreateElement("PlayerQuest");

                XmlAttribute idAttribute = playerData.CreateAttribute("ID");
                idAttribute.Value = quest.Details.ID.ToString();
                playerQuest.Attributes.Append(idAttribute);

                XmlAttribute isCompletedAttribute = playerData.CreateAttribute("IsCompleted");
                isCompletedAttribute.Value = quest.IsCompleted.ToString();
                playerQuest.Attributes.Append(isCompletedAttribute);

                playerQuests.AppendChild(playerQuest);
            }
            return playerData.InnerXml;
        }

        private void CallInventoryChangedEvent(Item item)
        {
            if (item != null)
            {
                if (item is Weapon)
                    OnPropertyChanged("Weapons");
                if (item is HealingPotion)
                    OnPropertyChanged("Potions");
            }
        }

        public void AddItem (Item item, int quantity) // lägg till item i inventariet
        {
            InventoryItem theitem = Inventory.SingleOrDefault(ii => ii.Details.ID == item.ID);
            if (theitem != null)
                theitem.Quantity += quantity;
            else
                Inventory.Add(new InventoryItem(item, quantity));
            CallInventoryChangedEvent(item);
        }

        public bool HasItem(Item item, int quantity) // kolla om spelaren har en item
        {
            return Inventory.Any(ii => ii.Details.ID == item.ID);
        }
        public void Heal(int health) 
        {
            CurrentHitPoints += health;
            if (CurrentHitPoints > MaximumHitPoints)
                CurrentHitPoints = MaximumHitPoints;
           
        }
        public bool HasOngoingQuest(Quest quest)
        {
            return Quests.Any(ii => ii.Details.ID == quest.ID);
        }

        public bool IsQuestCompleted(Quest quest)
        {
            foreach(PlayerQuest playerQuest in Quests)
            {
                if (playerQuest.IsCompleted && playerQuest.Details.ID == quest.ID)
                    return true;
            }
            return false;
        }

       public void RemoveItem(InventoryItem item, int quantity)
       {
           item.Quantity -= quantity;
           if(item.Quantity <= 0)
           {
               Inventory.Remove(item);
               CallInventoryChangedEvent(item.Details);
           }
       }

       public void LevelUp()
       {
           Level++;
          MaximumHitPoints += 10; 
           Heal(MaximumHitPoints);

       }
       public void RewardGold(int amount)
       {
           Gold += amount;
       }
    }
}
