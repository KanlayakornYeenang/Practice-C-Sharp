using System;

namespace DNA
{
    class DNA
    {
        static bool IsValidSequence(string halfDNASequence)
        {
            foreach (char nucleotide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucleotide))
                {
                    return false;
                }
            }
            return true;
        }

        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach (char nucleotide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucleotide)];
            }
            return result;
        }

        static string YNcheck(string x)
        {
            while (x != "Y" && x != "N")
            {
                Console.WriteLine("Please input Y or N.");
                x = Console.ReadLine();
            }
            return x;
        }

        static void Main(string[] args)
        {
            string YN;
            string DNA;
            YN = "Y";
            while (YN == "Y")
            {
                DNA = Console.ReadLine();
                if (IsValidSequence(DNA) == true)
                {
                    Console.WriteLine("Current half DNA sequence : {0}", DNA);
                    Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
                    YN = Console.ReadLine();
                    while (YN != "Y" && YN != "N")
                    {
                        Console.WriteLine("Please input Y or N.");
                        Console.WriteLine("Do you want to replicate it ? (Y/N) : ");
                        YN = Console.ReadLine();
                    }
                    if (YN == "Y")
                    {
                        Console.WriteLine("Replicated half DNA sequence : {0}" , ReplicateSeqeunce(DNA));
                        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                        YN = Console.ReadLine();
                        YN = YNcheck(YN);
                    }
                    else if (YN == "N")
                    {
                        Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                        YN = Console.ReadLine();
                        YN = YNcheck(YN);
                    }
                }
                else
                {
                    Console.WriteLine("That half DNA sequence is invalid.");
                    Console.WriteLine("Do you want to process another sequence ? (Y/N) : ");
                    YN = Console.ReadLine();
                    YN = YNcheck(YN);
                }
            }
        }
    }
}
