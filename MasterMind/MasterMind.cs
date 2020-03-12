using System;

namespace MasterMind
{
    public class MasterMind
    {
        private string code;

        public MasterMind()
        {
            CreateCode();
        }

        public string RunCode(string input)
        {

            if (!ValidateInput(input))
            {
                return "Error with inputed code the code must be 4 numbers between 1 and 6";
            }
            return Evaluate(input);//"code is good";
        }

        private string Evaluate(string input)
        {
            string result = "";

            if (input.Equals(code))
            {
                return "++++";
            }

            for(int i = 0; i <=3; i++)
            {
                if(input[i] == code[i])
                {
                    result += "+";
                }
                else if(code.Contains(input[i]))
                {
                    result += "-";
                }
                else
                {
                    result += " ";
                }
            }
            return result;
        }

        private void CreateCode()
        {
            var random = new Random();
            int digit = 1;
            while(digit <=4)
            {
                code += random.Next(1, 6);
                digit++;
            }
        }

        private bool ValidateInput(string input)
        {
            if (input.Length != 4)
            {
                return false;
            }

            foreach(char c in input)
            {
                if(!char.IsDigit(c))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
