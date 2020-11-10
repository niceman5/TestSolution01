using System;
using Npgg;
using System.Configuration;

namespace _01.ConsoleTest
{
    class Program
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

        static void Main(string[] args)
        {
            var ThreadTime = Convert.ToInt32(ConfigurationSettings.AppSettings["ThreadTime"]);
            var ServerIP = ConfigurationSettings.AppSettings["ServerIP"];
            var ServerPort = ConfigurationSettings.AppSettings["ServerPort"];

            Console.WriteLine(ThreadTime);
            Console.WriteLine(ServerIP);
            Console.WriteLine(ServerPort);

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
