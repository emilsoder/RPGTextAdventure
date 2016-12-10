using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGAdventurePlus
{
    public class StringProvider
    {
        #region MainFrm
        public static int _damageDealt { get; set; }
        public static string potionName { get; set; }

        public readonly string LevelRequriment = "Du måste minst vara på level ";
        public readonly string ItemRequrement = "Du behöver ";
        public readonly string ToGoHere = " för att gå hit.";
        public readonly string Missed = "Du missade din chans till attack!";
        public readonly string NoMagicDamage = "Din magiska formel utgjorde ingen skada!";
        public readonly string NoMagicEvent = "Din magiska formel gjorde ingen nytta";
        public readonly string NoDamage = "Din attack utgjorde ingen skada!";
        public readonly string NoMana = "Du har inte tillräckligt med Mana för att använda detta";
        public readonly string NoMagic = "Du kan inte använda denna magi i ett slag";
        public readonly string DodgeAttack = "Du lyckades ducka fiendens attack!";
        public readonly string Respawn = "Du återuppstod. Du befinner dig nu hemma i ditt hus.";
        public readonly string AttackDamage = "  poäng skada på dig!";
        public readonly string InBattleOnlyM = "Du måste vara i en kamp för att använda denna formel.";
        public readonly string BlankLine = " ";
        public readonly string Healed = "Du helade dig själv med ";
        public readonly string YouSee = "Du ser ";
        public readonly string Recovered = "Du återställde ";
        public readonly string YouGave = "Du utgjorde ";
        public readonly string Defeated = "Du besegrade ";
        public readonly string Dealt = " utgjorde";
        public readonly string Mana = " Mana!";
        public readonly string YouDied = "DU HAR DÖTT!";
        public readonly string YouUsed = "Du använde ";
        public readonly string ToRecover = " för att återställa din hälsa med ";
        public readonly string DamageOnEnemy = "  poäng magisk skada på fienden.";
        public readonly string YouGet = "Du fick ";
        public readonly string Gold = " guldpengar!";
        public readonly string Points = " i poäng!";
        public readonly string MagicDamage = " poäng magisk skada på dig!";
        public readonly string YourMaginDamage = "";
        public readonly string Teleport = "Teleporteringsformel använd!";
        public readonly string EnemyMagicDamage = " du gav " + _damageDealt.ToString() + " poäng magisk skada på fienden.";
        public readonly string PlayerDealedDamage = "Du gav " + _damageDealt.ToString() + " poäng skada på ";
        public readonly string PotionUsed = "Du använde " + potionName + " för att återställa ";
        public readonly string HealthPoints = " poäng hälsa ";
        #endregion

        #region frm.SkapaKaraktär
        public readonly string HumanRace = "Starta med 10 extra guldpengar";
        public readonly string ElfRace = "Starta med extra Mana och en magisk formel";
        public readonly string OrcRace = "Starta med extra attackpoäng och pansar";
        public readonly string DwarfRace = "Starta med ett stålsvärd";
        #endregion
    }
}
