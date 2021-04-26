using System;

namespace DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            string DNA;

            while (true)
            {
              
                while (true)
                {
                    Console.Write("DNA : ");
                    DNA = Console.ReadLine();

                    if (IsValidSequence(DNA) == true)
                    {
                        Console.WriteLine("Current half DNA sequence : {0} ", DNA);
                        break;
                    }
                    else if (IsValidSequence(DNA) == false)
                    {
                        Console.WriteLine("That half DNA sequence is invalid.");
                        
                       while (true)
                        {
                            Console.Write("Do you want to process another sequence ? (Y/N) : ");
                            string ans = Console.ReadLine();

                            if (ans == "Y")
                            {
                                break;
                            }
                            else if (ans == "N")
                            {
                                Console.WriteLine("Thanks for using");
                                return;
                            }
                            else
                                Console.WriteLine("Please input Y or N ");
                                continue;
                        }                                            
                    }
                }

                while (true)
                {
                    if (IsValidSequence(DNA) == true)
                    {
                        Console.Write("Do you want to replicate it ? (Y/N) : ");
                        string ans1 = Console.ReadLine();

                        if (ans1 == "Y")
                        {
                            ReplicateSeqeunce(DNA);
                            Console.WriteLine("Replicated half DNA sequence : {0}", ReplicateSeqeunce(DNA));

                          while (true)
                            {
                                Console.Write("Do you want to process another sequence? (Y/N) : ");
                                string ans3 = Console.ReadLine();

                                if (ans3 == "Y")
                                {
                                    break;
                                }
                                else if (ans3 == "N")
                                {
                                    Console.WriteLine("Thanks for using");
                                    return;
                                }
                                else
                                    Console.WriteLine("Please input Y or N ");
                                continue;
                            }                                                                                    
                        }
                        else if (ans1 == "N")
                        {
                            while (true)
                            {
                                Console.Write("Do you want to process another sequence? (Y/N) : ");
                                string ans2 = Console.ReadLine();

                                if (ans2 == "Y")
                                {
                                    break;
                                }
                                else if (ans2 == "N")
                                {
                                    Console.WriteLine("Thanks for using");
                                    return;
                                }
                                else
                                    Console.Write("Please input Y or N");
                            }
                        }
                    }
                    break;
                }            
            }                          
            
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
        }

        


    }
}
