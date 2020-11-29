using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class Weapon
    {
        public string WeaponName { get; }

        public string WeaponSound { get; }

        public Weapon(string weaponName, string weaponSound)
        {
            WeaponName = weaponName;
            WeaponSound = weaponSound;
        }
    }

    public static class WeaponStore
    {
        public static Dictionary<int, Weapon> WeaponMap = new Dictionary<int, Weapon>()
        {

            {0, new Weapon("Machine Gun", "RATATA")},
            {1, new Weapon("Sniper Rifle", "BING")},
            {2, new Weapon("Handgun", "BANG")},
            {3, new Weapon("Rocket Launcher","KABOOM")},
            {4, new Weapon("Grenade Launcher", "BOOM")},
            {5, new Weapon("Laser","ZAP")},
            {6, new Weapon("Nuke", "WOSHH")}
        };
        public static int Counter = 6;
    }

    public class WeaponInventory
    {
        public List<Weapon> Inventory = new List<Weapon>();
        public Weapon EquippedWeapon;
        
        public void AddWeapon(string command)
        {
            var key = int.Parse(command.Last().ToString());
            WeaponStore.WeaponMap.TryGetValue(key, out Weapon weapon);
            if (!Inventory.Contains(weapon))
            {
                if (Inventory.Count != 2)
                {
                    Inventory.Add(weapon);
                }
                else
                {
                    Inventory.RemoveAt(0);
                    Inventory.Add(weapon);
                }
            }
        }

        public void EquipWeapon(string command)
        {
            var key = int.Parse(command.Last().ToString());
            EquippedWeapon = Inventory[key];
            if (EquippedWeapon == null)
            {
                Console.WriteLine("Weapon not found in the inventory");
                Console.WriteLine("Weapons in your Inventory:");
                foreach (var item in Inventory)
                {
                    Console.WriteLine(item.WeaponName);
                }
            }
        }

        public string FireSound()
        {
            return EquippedWeapon.WeaponSound;
        }
    }

    public class Solution
    {   
        //Just in case, if you need to more weapons and their corresponding sounds to the store
        public void AddWeaponMap(string weaponName, string weaponSound)
        {
            WeaponStore.Counter++;
            WeaponStore.WeaponMap.Add(WeaponStore.Counter, new Weapon(weaponName, weaponSound));
        }
        
        public string[] solution(string[] A)
        {
            var fireSounds = new List<string>();
            var inventory = new WeaponInventory();
            
            for (int i = 0; i < A.Length; i++)
            {
                switch (A[i].Substring(0, 1))
                {
                    case "A": 
                        inventory.AddWeapon(A[i]);
                        break;
                    case "E": 
                        inventory.EquipWeapon(A[i]);
                        break;
                    case "F":
                        fireSounds.Add(inventory.FireSound());
                        break;
                }
            }

            return fireSounds.ToArray();
        }
    }
}
