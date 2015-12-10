using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab10
{
    class Perfect
    {
        static void Main(string[] args)
        {
            int sum,
                num = 1,
                div;
            const int LIMIT = 1000;

            while(num <= LIMIT)//loops 1000 times
            {
                sum = 0;
                div = 1;

                while(div < num)//while the dividen is less than the tested number
                {
                    if((num % div) == 0)//if dividen can multiplied evenly into num
                    {
                        sum += div;
                    }

                    ++div;
                }

                if (sum == num)//if num is perfect
                    WriteLine("{0} ", num);

                ++num;//add one to num
            }
        }
    }
}
