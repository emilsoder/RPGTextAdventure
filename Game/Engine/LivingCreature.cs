using System.Collections.Generic;
using System.ComponentModel;

namespace Engine
{
    public class LivingCreature : INotifyPropertyChanged
    {
        private int _currentHitPoints, _level, _currentMana;
        public int CurrentHitPoints
        {
            get { return _currentHitPoints; }
            set { _currentHitPoints = value; OnPropertyChanged("CurrentHitPoints"); }
        }

        public int MaximumHitPoints { get; set; }
        public int Level
        {
            get { return _level; }
            set { _level = value; OnPropertyChanged("Level"); }
        }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligent { get; set; }
        public int CurrentMana
        {
            get { return _currentMana; }
            set { _currentMana = value; OnPropertyChanged("CurrentMana"); }
        }

        public int MaximumMana { get; set; }
        public Armour ArmourUsed { get; set; }
        public List<SpellList> Spells { get; set; }
        public List<BuffsList> Buffs { get; set; }
        public int TemporaryMaximumMana { get; set; }
        public Race CreatureRace { get; set; }

        #region LEVANDE VARELSE
        public LivingCreature(int currentHitPoints, int maximumHitPoints, int level, int strength, int dexterity, int intelligent, int currentMana, int maximumMana, Race race, Armour armourUsed = null)
        {
            CurrentHitPoints = currentHitPoints;
            MaximumHitPoints = maximumHitPoints;
            Level = level;
            Strength = strength;
            Dexterity = dexterity;
            Intelligent = intelligent;
            CurrentMana = currentMana;
            MaximumMana = maximumMana;
            ArmourUsed = armourUsed;
            Spells = new List<SpellList>();
            Buffs = new List<BuffsList>();
            TemporaryMaximumMana = 0;
            CreatureRace = race;
        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name)); 
        }

        public void DealDamage(int amount)
        {
            CurrentHitPoints -= amount;
        }
        public bool HasSpell(Spell spell)
        {
            foreach(SpellList sp in Spells)
            {
                if (sp.Details.ID == spell.ID)
                    return true;
            }
            return false;
        }
        public void AddSpell(Spell spell)
        {
            if (!HasSpell(spell))
                Spells.Add(new SpellList(spell));
            OnPropertyChanged("Spells");
        }

        public void RemoveSpell(Spell spell)
        {
            foreach (SpellList sp in Spells)

                if (sp.Details.ID == spell.ID)
                {
                    Spells.Remove(sp);
                    OnPropertyChanged("Spells");
                    break;
                }
        }
        public void DrainMana(int amount)
        {
            CurrentMana -= amount;
        }
        public void RestoreManaToFull()
        {
            CurrentMana = MaximumMana;
        }
        public void RestoreMana(int amount)
        {
            if ((CurrentMana + amount) > MaximumMana)
                CurrentMana = MaximumMana;
            else
                CurrentMana += amount;
        }
        public void RemoveBuff(Buff buff)
        {
            if(Buffs.Count != 0)
            foreach(BuffsList bl in Buffs)
            {
                if (buff.ID == bl.Details.ID)
                {
                    Buffs.Remove(bl);
                    break;
                }
            }
        }
        public void RemoveAllBuffs()
        {
            if (Buffs.Count != 0)
            {
                foreach (BuffsList bl in Buffs)
                {
                    RemoveBuff(bl.Details);
                }
            }
        }
    }
}
