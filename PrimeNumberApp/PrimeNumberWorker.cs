using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrimeNumberApp
{
    public class PrimeNumberWorker
    {
        public bool isNumberPrime(int number)
        {
            bool isPrime = false;
            foreach (int divisor in Enumerable.Range(2, number - 2))
            {
                if (number % divisor == 0)
                {
                    break;
                }
                if (divisor == number - 1)
                {
                    isPrime = true;
                }
            }
            return isPrime;
        }
        public List<int> GetPrimeNumbersRange(int minValue, int maxValue)
        {
            List<int> primeNos = new List<int>();
            if (minValue >= maxValue)
            {
                primeNos.Add(0);
                return primeNos;
            }

            foreach (int number in Enumerable.Range(minValue, maxValue - minValue))
            {
                if (number == 1 || number == 0) { continue; }
                if (number == 2) { primeNos.Add(number);}
                foreach (int x in Enumerable.Range(2, number - 2))
                {
                    if (number % x == 0) { break; }
                    if (x == number - 1)
                    {
                        primeNos.Add(number);
                    }
                }
            }
            return primeNos;
        }

        public List<int> GetPrimeNumbers(int count)
        {
            List<int> vs = new List<int>();
            int i = 0;

            if (count >= 2) { vs.Add(2); }
            foreach (int number in Enumerable.Range(2, int.MaxValue - 2))
            {
                if (count == 0) { vs.Add(0); break; }
                if (count == 1) { vs.Add(2); break; }

                foreach (int x in Enumerable.Range(2, number - 1))
                {
                    if (number % x == 0) { break; }//not a prime
                    if (x == number - 1)
                    {
                        vs.Add(number);
                        i++;
                        break;
                    }
                }
                if (i == count) { break; }
            }
            return vs;
        }
    }
}