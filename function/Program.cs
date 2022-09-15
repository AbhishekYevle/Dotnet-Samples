using System;

namespace useFun
{
    class program 
    {
        public void function1()
        {
                Console.WriteLine("Enter String:");
                var Name = Console.ReadLine();
                char[] nameArr = Name.ToCharArray();
                bool result = false;
                int count = 0;

                for(int i = 0; (i < nameArr.Length) && (result==false); i++)
                {
                    for(int j = 0; (j < nameArr.Length); j++,count++)
                    {
                        if(nameArr[i]==nameArr[j])
                        {
                            result = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                if(count==0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }

        public static void Main(string[] args)
        {
                program condition = new program();
                
                condition.function1();
                
                
        }
    }
}
