using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARENTHESIS
{
    class checkparenthesis
    {
        public bool balanceparenthesis(string order)
        {
            stack stack1 = new stack();
            
            for(int i=0;i<order.Length;i++)
            {
                char cha = order[i];
                if (cha == '(' || cha == '{' || cha == '[')
                {
                    stack1.push(cha);
                }
                else if ((cha == '(' && cha == ')') || (cha == '{' && cha == '}') || (cha == '[' && cha == ']'))
                {
                    stack1.pop();
                }
                else
                {
                    return false;
                }
            }
            return stack1.isempty();
        }
    }
}
