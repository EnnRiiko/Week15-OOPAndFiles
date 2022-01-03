using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class ChristmasGift
        {
            string name;
            string gift;

            public ChristmasGift(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            

            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }

        }
        static void Main(string[] args)
        {
            //Anna wants new earrings for Christmas
         
            List<ChristmasGift> myChristmasGift = new List<ChristmasGift>();
            string[] giftFromFile = GetDataFromFile();

            foreach (string line in giftFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                ChristmasGift newChristmasGift = new ChristmasGift(tempArray[0], tempArray[1]);
                myChristmasGift.Add(newChristmasGift);
            }

            foreach (ChristmasGift giftFromList in myChristmasGift)
            {
                Console.WriteLine($"{giftFromList.Name} wants {giftFromList.Gift} for Christmas.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }

        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
