using Newtonsoft.Json.Linq;

namespace CodingChallenge.HackerRank
{
    public class PrefixNotation
    {
        //Evaluates the prefix expression and calculates the result for the given variable values


        private   Boolean isOperand(char c)
        {
            if (c >= 48 && c <= 57)
                return true;
            else
                return false;
        }

        public int CalculateExpression(string expression, string variables)
        {
            Stack<int> Stack = new Stack<int>();
           
            var exprsn = expression.Trim().Split(' ');


            if (exprsn.Length <= 0)

                throw new InvalidOperationException();


            for (int j = exprsn.Length - 1; j >= 0; j--)
            {
                if (exprsn[j].Length == 0) continue;


                if (exprsn[j].Length > 1)
                {
                    bool hasOperand = false;
                    var checkforMultiple = exprsn[j].ToCharArray();
                    for (var k = 0; k < checkforMultiple.Length; k++)
                    {

                        if (!isOperand(checkforMultiple[k]))

                        {
                            if (!hasOperand)
                                hasOperand = true;

                            throw new InvalidOperationException();

                        }

                    }
                }


                if (Char.IsLetter(exprsn[j].ToCharArray()[0]))
                {
                    try
                    {
                        var jo = JObject.Parse(variables);
                        var id = jo[exprsn[j]].ToString();
                        Stack.Push(int.Parse(id));
                    }
                    catch (Exception e)
                    {
                        throw new Exception("Invalid Variable");
                    }

                }

                else if (isOperand(exprsn[j].ToCharArray()[0]))
                    Stack.Push(int.Parse(exprsn[j]));

                else
                {


                    int o1 = Stack.Peek();
                    Stack.Pop();
                    int o2 = Stack.Peek();
                    Stack.Pop();




                    switch (exprsn[j].ToCharArray()[0])
                    {
                        case '+':
                            Stack.Push(o1 + o2);
                            break;
                        case '-':
                            Stack.Push(o1 - o2);
                            break;
                        case '*':
                            Stack.Push(o1 * o2);
                            break;
                        case '/':
                            Stack.Push(o1 / o2);
                            break;
                    }
                }
            }


            if (Stack.Count > 1 || Stack.Count == 0)
            {
                throw new InvalidDataException();
            }
            else
            {
                return Stack.Peek();
            }






        }
    }
}