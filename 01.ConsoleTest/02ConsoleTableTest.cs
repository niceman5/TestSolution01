using Npgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ConsoleTest
{
    class Item
    {
        public string Name { get; set; }
        public Rarity Rarity { get; set; }
        public string Slot { get; set; }
    }

    enum Rarity
    {
        Normal,
        Magic,
        Unique,
        Legendary,
    }

    class ConsoleTableTest
    {
        public void ConsoleTablePrint()
        {
            var items = new[]
            {
                new Item(){ Name= "Leoric's Crown", Rarity = Rarity.Normal, Slot ="Helm"},
                new Item(){ Name= "Thunderfury", Rarity = Rarity.Unique, Slot ="One Handed Weapon"},
                new Item(){ Name= "할배검 the grandfather", Rarity = Rarity.Legendary, Slot ="Two Handed Weapon"},
                new Item(){ Name= "WINDFORCE", Rarity = Rarity.Magic, Slot ="양손무기"},
            };

            ConsoleTable.Write(items, item => item.Rarity switch
            {
                Rarity.Magic => ConsoleColor.DarkCyan,
                Rarity.Unique => ConsoleColor.DarkMagenta,
                Rarity.Legendary => ConsoleColor.DarkYellow,
                _ => ConsoleColor.White
            });

            ConsoleTable.TableColor = ConsoleColor.Red;
            ConsoleTable.ColumnColor = ConsoleColor.Cyan;
            ConsoleTable.RowColor = ConsoleColor.White;

            ConsoleTable.WriteSingle(items[0]);
        }
    }
}
