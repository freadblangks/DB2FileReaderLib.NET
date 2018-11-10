﻿using System;
using System.IO;
using CascStorageLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var build = "8.0.1.26231";
            var dbcdir = @"Z:\DBCs\" + build + @"\dbfilesclient";

            foreach (var file in Directory.GetFiles(dbcdir))
            {
                try
                {
                    var definition = DefinitionManager.CompileDefinition(file, build);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Failed to load " + Path.GetFileNameWithoutExtension(file) + ": " + e.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
