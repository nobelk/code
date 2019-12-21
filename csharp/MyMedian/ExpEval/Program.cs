using System;
using System.Text;
using System.Collections.Generic;

namespace ExpEval
{

    public class ExpEval
    {
        private Stack<string> store = new Stack<string>();


        public int Evaluate(string input)
        {
            if(string.IsNullOrEmpty(input))
            {
                return 0;
            }

            // parse to string
            int evaluation = 0;

            // store          
            int index=0;
            while(index<input.Length)
            {
                // push case
                //number, +, -
                if(input[index].Equals("+") 
                || 
                input[index].Equals("-")
                ||
                input[index].Equals("(")
                )
                {
                    this.store.Push(input[index].ToString());
                }

                else if(Char.IsNumber(((char) input[index])))
                {
                    StringBuilder tmp = new StringBuilder();
                    
                    while(Char.IsNumber(input[index]))
                    {
                        tmp.Append(input[index].ToString());
                        index++;
                    }
                    
                    this.store.Push(tmp.ToString());
                    continue;
                }

                // pop/eval case                
                else if (input[index].Equals("=")
                ||
                input[index].Equals(")"))
                {
                    string current = this.store.Pop();
                    while(this.store.Count>0)
                    {
                        if(current=="+")
                        {
                            evaluation+=Int32.Parse(this.store.Pop().ToString());
                        }
                        else if(current=="-")
                        {
                            evaluation+=Int32.Parse(this.store.Pop().ToString());
                        }
                        else if(current=="(")
                        {
                            this.store.Push(evaluation.ToString());
                        }
                    }
                }


            index++;

            }


            // return answer
            return evaluation;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
