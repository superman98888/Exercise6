using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
        public class Account
        {
            private int money;
            private int wallet;
            public Account(int amount)
            {
                amount = money;
                money = wallet;
            }
            public void Deposit(int amount)
            {
                amount += money;
            }
            public void withDraw(int amount)
            {
                amount -= money;
            }
            public int Balance(int amount)
            {
                return money;
            }
        }
    }
