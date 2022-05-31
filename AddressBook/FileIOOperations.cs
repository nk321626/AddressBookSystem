﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddressBook
{
    /// <summary>
    /// File IO Operation Program(UC13)
    /// </summary>
    public class FileIOOperations
    {
        //Declaring file path
        public static string filePath = @"C:\Users\nk321\OneDrive\Desktop\project\AddressBookSystem\AddressBook\AddressBook.txt";
        //Method to Write data into the text file using stream writer (UC13)
        public static void WriteToFile(Dictionary<string, AddressBookEntry> addressBookDictionary)
        {
            StreamWriter writer = File.AppendText(filePath);
            foreach (var addressBookObj in addressBookDictionary.Values)
            {
                foreach (var contact in addressBookObj.contactList.Values)
                {
                    writer.WriteLine(contact);
                }
            }
            Console.WriteLine("\nSuccessfully added the address book data to text file.");
            writer.Close();
        }
        //Method to read data from the text file using stream reader(UC13)
        public static void ReadFromFile()
        {
            Console.WriteLine("Below are the contents of text file");
            string line;
            StreamReader sr = File.OpenText(filePath);
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            sr.Close();
        }
    }
}
