﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace labra7
{
    [Serializable]
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
    class Program
    {
        static void TestaaSerialisointi(string fiilu)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                // create list for persons
                List<Person> persons = new List<Person>();
                // add a few persons to list
                persons.Add(new Person { Firstname = "Kirsi", Lastname = "Kerneli" });
                persons.Add(new Person { Firstname = "Matti", Lastname = "Konsoli" });
                persons.Add(new Person { Firstname = "Teppo", Lastname = "Terävä" });

                // create a file for persons
                Stream writeMultipleStream = new FileStream(fiilu + "MyPersons.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                // write persons array to disk, note: uses formatter in previous code
                formatter.Serialize(writeMultipleStream, persons);
                // close file
                writeMultipleStream.Close();

                // create stream for reading persons
                Stream openStream = new FileStream(fiilu + "MyPersons.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                // create a list and read persons into it from disk
                List<Person> readPersons = (List<Person>)formatter.Deserialize(openStream);
                // close stream
                openStream.Close();

                // proof
                foreach (Person p in readPersons)
                {
                    Console.WriteLine("Person is {0} {0}", p.Firstname, p.Lastname);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void TestaaLukeminen2(string fiilu)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(fiilu);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
        static void TestaaLukeminen(string fiilu)
        {
            //string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                string text = System.IO.File.ReadAllText(fiilu);
                System.Console.WriteLine("Contents of test.txt:\n" + text);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
        static void TestaaAppend()
        {
            try
            {
                string path = @"Z:\Olio ohjelmointi\IOfile\tesaaAppend.txt";
                // Tutkitaan onko tiedosto olemassa, ja jollei ole niin luodaan tiedosto, ja siihen kolme riviä
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Testitiedosto");
                        sw.WriteLine("luotu: " + DateTime.Now.ToString());
                        sw.WriteLine("luonut: Anton T");
                    }
                }

                // LisätäänAppendText-metodilla tekstiä olemassaolevaan
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Tässä");
                    sw.WriteLine("kolme");
                    sw.WriteLine("lisäriviä...");
                }

                // Avataan tiedosto lukemista varten
                using (StreamReader sr = File.OpenText(path))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void TestaaMyDocuments()
        {
            // find my documents folder
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            // a few sample lines
            string[] lines = { "First line", "Second line", "Third line" };
            // write the string array to a new file named "WriteLines.txt".
            // IDisposable object use using, so resources will be disposed after using {}
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt")) // escape sequences are ignored
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }
            Console.WriteLine(string.Format("Tiedosto luotu onnistuneesti"));
            Console.WriteLine(mydocpath + @"\WriteLines.txt");
        }
        static void TestaaTiedostonKirjoitus()
        {
            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter(@"Z:\Olio ohjelmointi\IOfile\test.txt");
                outputFile.WriteLine("Here is a sample text to file.");
                outputFile.WriteLine("Here is a sample text to file.");
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Some exception happened!");
                Console.WriteLine(ex.Message); // Access to the path 'c:\test.file' is denied.
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
        }
        static void Main(string[] args)
        {
            //TestaaTiedostonKirjoitus();
            //TestaaMyDocuments();
            //TestaaAppend();
            //TestaaLukeminen(@"Z:\Olio ohjelmointi\IOfile\tesaaAppend.txt");
            //TestaaLukeminen2(@"Z:\Olio ohjelmointi\IOfile\tesaaAppend.txt");
            //TestaaSerialisointi(@"Z:\Olio ohjelmointi\IOfile\");
        }
    }
}
