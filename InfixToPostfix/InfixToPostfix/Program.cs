using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using System.Collections;

namespace InfixToPostfix
{
    class PostfixConverter
    {
        
        static int checkpresidence(char checkoperator)
        {
            switch (checkoperator)
            {
                case '+': return 0;
                case '-': return 0;

                case '*': return 1;
                case '/': return 1;
                default: throw new Exception("Illegal Argument");
            }

        }

        private static string[] ConvertToStringArray(Stack<dynamic> temporary)
        {
            StringBuilder s = new StringBuilder();
            double flag;
            int templength = temporary.Count;
            List<string> t = new List<string>();

            for (int i = 0; temporary.Count != 0; i++)
            {
                s.Clear();
                flag = 0;
                if (temporary.Count == templength)
                {
                    if (temporary.Peek() == '-')
                    {
                        s.Append(temporary.Pop().ToString());
                    }
                }
                else if (Input.IsOperator(temporary.Peek()) && Input.IsOperator(t.Last().Last()))
                {
                    s.Append(temporary.Pop().ToString());
                }
                while (((temporary.Peek()) >= 48 && (temporary.Peek()) <= 57) || temporary.Peek() == '.')//added -
                {
                    s.Append(temporary.Pop().ToString());
                    flag = 1;
                    if (temporary.Count == 0)
                        break;
                }
                if (flag == 1)
                {
                    t.Add(s.ToString());
                }
                if (temporary.Count != 0)
                    t.Add((temporary.Pop()).ToString());
            }
            return t.ToArray<string>();
        }
        public static string[] InfixtoPostfix(string expression)
        {
            Stack<char> operators = new Stack<char>();
            //  StringBuilder postfix = new StringBuilder();
            List<string> postfix = new List<string>();
            Stack<dynamic> temporary = new Stack<dynamic>();
            for (int i = expression.Length - 1; i >= 0; i--)
            {
                temporary.Push(expression[i]);
            }

            string[] t1 = ConvertToStringArray(temporary);

            for (int i = 0; i < t1.Length; i++)
            {
                int f=0,k=0;
                foreach (char c in t1[i])
                {
                    if (c == '-')
                    {
                        f = 1;  
                    }
                    if (c >= 48 && c <= 57)
                    {
                        k = 1;
                    }
                }
                if (f == 1 && k == 1)
                {
                    postfix.Add(t1[i]);
                    continue;
                }
 
                if (t1[i].First() == '+' || t1[i].First() == '/' || t1[i].First() == '*' || t1[i].First() == '-')
                {
                    while (operators.Count != 0 && (checkpresidence(t1[i].First()) <= checkpresidence(operators.Peek())))
                    {
                        postfix.Add((operators.Pop()).ToString());

                    }
                    operators.Push(t1[i].First());
                }
                else
                {
                    postfix.Add(t1[i]);
                }
            }
            while (operators.Count != 0)
            {
                postfix.Add(operators.Pop().ToString());
            }
            return postfix.ToArray<string>();
        }
    }
    class PostfixEval
    {
        public static void CalculatePostfix(string[] expression)
        {
            Stack<double> operands = new Stack<double>();
            double operand2, operand1, result;

            for (int i = 0; i < expression.Length; i++)
            {
                if ((expression[i].Last() == '+' || expression[i].Last() == '/' || expression[i].Last() == '*' || expression[i].Last() == '-') && operands.Count!=0)
                {
                    operand2 = operands.Pop();
                    operand1 = operands.Pop();
                    if (expression[i].First() == '/')
                    {
                        result = Division.DivideTwoNumbers(operand1, operand2);
                        operands.Push(result);
                    }
                    else if (expression[i].First() == '*')
                    {
                        result = Multiplication.MultiplyTwoNumbers(operand1, operand2);
                        operands.Push(result);
                    }
                    else if (expression[i].First() == '+')
                    {
                        result = Addition.AddTwoNumbers(operand1, operand2);
                        operands.Push(result);
                    }
                    else if (expression[i].First() == '-')
                    {
                        result = Subtraction.SubtractTwoNumbers(operand1, operand2);
                        operands.Push(result);
                    }
                }
                else
                {
                    operands.Push(Double.Parse(expression[i]));
                }
            }
            //-------------------------
            Console.WriteLine(operands.Peek());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string check;
            label:
                string expression;
                string[] postfix_expression;
                expression = Input.GetInputFromUser();
                postfix_expression = PostfixConverter.InfixtoPostfix(expression);
                Console.WriteLine("Answer");
                PostfixEval.CalculatePostfix(postfix_expression);
                //foreach(string s in postfix_expression)
                //Console.Write(s);
                Console.WriteLine("\nTo continue press any key to exit press n");
                check = Console.ReadLine();
           
            // Console.ReadKey();
                switch (check)
            {
                case "N":
                case "n":
                    break;
                default:goto label;
            }
        }
    }
}
