﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeProblems.Easy
{
    /*762. Prime Number of Set Bits in Binary Representation
     * Given two integers left and right, return the count of numbers in the inclusive range [left, right] having a prime number of set bits in their binary representation.

        Recall that the number of set bits an integer has is the number of 1's present when written in binary.

        For example, 21 written in binary is 10101, which has 3 set bits.

        Example 1:
        Input: left = 6, right = 10
        Output: 4
        Explanation:
        6  -> 110 (2 set bits, 2 is prime)
        7  -> 111 (3 set bits, 3 is prime)
        8  -> 1000 (1 set bit, 1 is not prime)
        9  -> 1001 (2 set bits, 2 is prime)
        10 -> 1010 (2 set bits, 2 is prime)
        4 numbers have a prime number of set bits.
        
        Example 2:
        Input: left = 10, right = 15
        Output: 5
        Explanation:
        10 -> 1010 (2 set bits, 2 is prime)
        11 -> 1011 (3 set bits, 3 is prime)
        12 -> 1100 (2 set bits, 2 is prime)
        13 -> 1101 (3 set bits, 3 is prime)
        14 -> 1110 (3 set bits, 3 is prime)
        15 -> 1111 (4 set bits, 4 is not prime)
        5 numbers have a prime number of set bits.

        Constraints:
        1 <= left <= right <= 106
        0 <= right - left <= 104
    */
    public class clsPrimeNumberOfSetBitsInBinaryRepresentation
    {
        public int CountPrimeSetBits(int left, int right)
        {
            int result = 0;
            while (left <= right)
            {
                if (IsPrime(countBits(left)))
                    result++;
                left++;
            }
            return result;
        }

        private int countBits(int n)
        {
            int count = 0;
            while (n != 0)
            {
                if ((n & 1) == 1)
                    count++;
                n >>= 1;
            }
            return count;
        }

        private bool IsPrime(int n)
        {
            //Bits count max will be 32 so putting hardcode prime numbers
            if (n == 2 || n == 3 || n == 5 || n == 7 || n == 11 || n == 13 || n == 17 || n == 19)
                return true;
            return false;
        }

        /* Find prime numbers
        private bool[] IsPrime(int n)
        {
            bool[] prime = new bool[n + 1];
            Array.Fill(prime, true);
            prime[0] = prime[1] = false;
            for (int i = 2; i * i <= n; i++)
            {
                for (int j = 2 * i; j <= n; j += i)
                {
                    prime[j] = false;
                }
            }
            return prime;
        }
        */
}
}
