﻿// See https://aka.ms/new-console-template for more information

namespace ConvertApiJson
{
    class Program
    {
        static void Main(string[] args)
        {

            if (CheckVariant.CheckResult(args))
            {
                JsonRoot readRoot = JsonStream.Read(args[0], args[2]);
                JsonStream.Write(args[1], readRoot);
            }

        }
    }
}
