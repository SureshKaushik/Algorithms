using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaysianNetwork.Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            FindProbabilityOfCancer();
            Console.ReadLine();
        }

        public static void FindProbabilityOfCancer()
        {
            //find Smoker = Y, Smoker = N
            Console.WriteLine("Enter Yes or No.");
            string smoker = Console.ReadLine();

            if(smoker.ToLower()=="yes")
            {
                //H-B-F, H-L-F
                Console.WriteLine("Enter Bromchitis present then Yes else No");
                string bromC = Console.ReadLine();
                if (bromC.ToLower() == "yes")
                {

                }
            }

            if(smoker.ToLower()=="no")
            {
                Console.WriteLine("Not smoker");
            }

        }

        public static void SampleExample1()
        {
//            Example 5.1 Suppose your favorite stock NASDIP is down-graded by a reputable
//analyst and it plummets from $40 to $10 per share. You feel this is a good
//buy, but there is a lot of uncertainty involved. NASDIP’s quarterly earnings are
//about to be released and you think they will be good, which should positively influence
//its market value. However, you also think there is a good chance the whole
//market will crash, which will negatively influence NASDIP’s market value. In
//an attempt to quantify your uncertainty, you decide there is a .25 probability
//            the market will crash, in which you case feel NASDIP will go to $5 by the end
//of the month. If the market does not crash, you feel by the end of the month
//NASDIP will be either at $10 or at $20 depending on the earnings report. You
//think it is twice as likely it will be at $20 as at $10. So you assign a .5 probability
//to NASDIP being at $20 and a .25 probability to it being at $10 at month end.
//Your decision now is whether to buy 100 shares of NASDIP for $1000 or to
//leave the $1000 in the bank where it will earn .005 interest in the next month.
//            One way to make your decision is to determine the expected value of your
//investment if you purchase NASDIP and compare that value to the amount of
//money you would have if you put the money in the bank. Let X be a random
//variable, whose value is the worth of your $1000 investment in one month if you
//purchase NASDIP. If NASDIP goes to $5, your investment will be worth $500,
//if it stays at $10, your investment will be worth $1000, and if it goes to $20, it
//will be worth $2000. Therefore,

            // .5 % -----------$20 ........... 100 shares
            // .25%------------$10
                 }
    }
}
