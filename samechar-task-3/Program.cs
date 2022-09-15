using System;

namespace logic
{
    class multiChar
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter String:");
            string Word = Console.ReadLine();
            char[] wordArr = Word.ToCharArray();
            bool True = true;
            bool False = false;
            var list = new List<string>();
            
            for(int i = 0; i < wordArr.Length; i++ )
            {
                for(int j = i+1; j < wordArr.Length; j++)
                {
            
                    if(wordArr[i]!=wordArr[j])
                    {
                        continue;

                    }
                    else 
                    {
                        list.Add(True.ToString());
                        break;
                    } 
                }    
            }

            Console.WriteLine($"Count: {list.Count}");
            if(list.Count==0)
            {
                Console.WriteLine(False);
            }
            else
            {
                Console.WriteLine(True);
            }
                
        }
    }


}