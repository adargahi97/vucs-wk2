﻿using System;
using System.Collections.Generic;
using System.Text;
using Week_5;

namespace Week_5
{
    public class Character
    {
        //name, hit chance, max life, health, block, equipped weapon
        private string _name;
        private int _maxHealth;
        private int _hitChance;
        private int _health;
        private int _block;
        private Weapon _weapon;

        public Character(string _name, int _maxHealth, int _hitChance, int _health, int _block, Weapon _weapon)
        {
            this._name = _name;
            this._maxHealth = _maxHealth;
            this._hitChance = _hitChance;
            this._health = _health;
            this._block = _block;
            this._weapon = _weapon;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MaxHealth
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value;}
        }

        public int HitChance
        {
            get { return _hitChance; }

            set { _hitChance = _weapon.BonusHitChance + value; }
        }

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }

        public void Desc()
        {
            Console.WriteLine("Name: {0}\nMax Health: {1}\nCurrent Health: {2}\nHit Chance: {3}\nBlock: {4}\nWeapon: {5}", _name, _maxHealth, _health, _hitChance, _block, _weapon.Name);
        }
        
        public int damageDealt()
        {
            Random rnd = new Random();
            int weaponDmg = rnd.Next(_weapon.MinDamage, _weapon.MaxDamage);
            int hcToBeat = rnd.Next(0, (HitChance/2));

            if (HitChance > hcToBeat)
            {
                return weaponDmg;
            }
            else
            {
                return 0;
            }
        }


        /* TODO:
         *  Ability to create a character object to be used in the dungeon for creating your player and the monsters they battle
            Calculate the hit chance (e.g. player hit chance + weapon bonus hit chance)
            Calculate the damage (e.g. using System.Random to choose a number between the equipped weapon minimum and maximum damage)
         */
    }
}