﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 
 * Isha Garg c0732132
 * Dheeraj Jain c0723560
 */
namespace c0723560_c0732132

{ 
        /// Bank Account demo class.
 
        public class BankAccount
        {
            private string m_customerName;

            private double m_balance;

            private bool m_frozen = false;

            private BankAccount()
            {
            }
            public BankAccount(string customerName, double balance)
            {
                m_customerName = customerName;
                m_balance = balance;
            }
            public string CustomerName
            {
                get { return m_customerName; }
            }
            public double Balance
            {
                get { return m_balance; }
            }
            public void Debit(double amount)
            {
                if (m_frozen)
                {
                    throw new Exception("Account frozen");
                }

                if (amount > m_balance)
                {
                    throw new ArgumentOutOfRangeException("amount");
                }

                if (amount < 0)
                {
                    throw new ArgumentOutOfRangeException("amount");
                }

                m_balance += amount; // intentionally incorrect code
            }

           
        }
    }