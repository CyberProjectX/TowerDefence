using System;
using System.Collections.Generic;

namespace TD
{
    public class TowerInfo
    {
        private readonly Dictionary<Guid, AuraInfo> allAuras;
        private float lastFireTime;

        public TowerInfo(TowerSettings settings)
        {
            allAuras = new Dictionary<Guid, AuraInfo>();
            MainDescription = new MainTowerDescription(settings);
            ActualDescription = new ActualTowerDescription(settings);
            Bonus = new TowerBonus(MainDescription, ActualDescription);
            OwnAuras = settings.Auras;
            AddAuras(OwnAuras);
        }

        public IEnumerable<AuraInfo> Auras
        {
            get
            {
                return allAuras.Values;
            }
        }

        public IEnumerable<AuraInfo> OwnAuras
        {
            get;
            private set;
        }

        public ActualTowerDescription ActualDescription
        {
            get;
            private set;
        }

        public MainTowerDescription MainDescription
        {
            get;
            private set;
        }

        public TowerBonus Bonus
        {
            get;
            private set;
        }

        public TowerInfo AddAuras(IEnumerable<AuraInfo> auras)
        {
            foreach (var aura in auras)
            {
                AddAura(aura);
            }
            return this;
        }

        public TowerInfo AddAura(AuraInfo aura)
        {
            if (!IsAuraAdded(aura))
            {
                AddAuraInternal(aura);
            }
            return this;
        }

        public TowerInfo RemoveAura(AuraInfo aura)
        {
            if (IsAuraAdded(aura))
            {
                RemoveAuraInternal(aura);
            }
            return this;
        }

        public bool CanFire(float currentTime)
        {
            return lastFireTime + ActualDescription.AttackRate < currentTime;
        }

        public HitInfo Fire(float currentTime)
        {
            var hit = new HitInfo();

            if (CanFire(currentTime))
            {
                hit.Damage = (int)ActualDescription.Damage;
                if (RandomHelper.WasHappened(ActualDescription.CritRate))
                {
                    hit.Damage = hit.Damage * (int)ActualDescription.CritMultiplier;
                }
            }

            lastFireTime = currentTime;

            return hit;
        }

        private bool IsAuraAdded(AuraInfo aura)
        {
            return allAuras.ContainsKey(aura.Id);
        }

        private void AddAuraInternal(AuraInfo aura)
        {
            Bonus.Damage += aura.Damage;
            Bonus.AttackRate += aura.AttackRate;
            Bonus.AttackDistance += aura.AttackDistance;
            Bonus.CritRate += aura.CritRate;
            Bonus.CritMultiplier += aura.CritMultiplier;

            allAuras.Add(aura.Id, aura);
        }

        private void RemoveAuraInternal(AuraInfo aura)
        {
            allAuras.Remove(aura.Id);

            Bonus.Damage -= aura.Damage;
            Bonus.AttackRate -= aura.AttackRate;
            Bonus.AttackDistance -= aura.AttackDistance;
            Bonus.CritRate -= aura.CritRate;
            Bonus.CritMultiplier -= aura.CritMultiplier;
        }
    }
}