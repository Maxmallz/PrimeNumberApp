using System;
using System.Text;


namespace PrimeNumberApp
{
    public partial class index : System.Web.UI.Page
    {
        protected void isPrimeBtn_Click(object sender, EventArgs e)
        {
            int input;
            if(!int.TryParse(isPrimeTxt.Text, out input))
            {
                isPrimeErrorLbl.Text = "Only Whole Numbers Allowed";
                return;
            }
            PrimeNumberWorker pnw = new PrimeNumberWorker();
            if (pnw.isNumberPrime(input))
            {
                primeNosTxt.Text = input + " is a prime number";
            }
            else
            {
                primeNosTxt.Text = input + " is a not prime number";
            }
        }
        protected void getPrimeRangeBtn_Click(object sender, EventArgs e)
        {
            int minValue;
            int maxValue;

            if(!int.TryParse(minValueTxt.Text, out minValue) || !int.TryParse(maxValueTxt.Text, out maxValue))
            {
                primeBetweenErrorLbl.Text = "minimum and maximum values must be integers.";
                return;
            }
            if (minValue > maxValue)
            {
                primeBetweenErrorLbl.Text = "min value must be less than max value" +
                    "";
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach(int i in new PrimeNumberWorker().GetPrimeNumbersRange(minValue, maxValue))
            {
                sb.Append(i+"");
                sb.AppendLine();
            }
            primeNosRangeTxt.Text = sb.ToString();
        }
        protected void getAllPrimes_Click(object sender, EventArgs e)
        {
            int count;
            if (!int.TryParse(totalPrimeTxt.Text, out count))
            {
                primeNoListErrorLabel.Text = "enter a whole number";
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach(int i in new PrimeNumberWorker().GetPrimeNumbers(count))
            {
                sb.Append(i + ", ");
            }
            allPrimesTxt.Text = sb.ToString();
        }
    }
}