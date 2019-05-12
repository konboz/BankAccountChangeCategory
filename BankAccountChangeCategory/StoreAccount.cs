using System;
using System.Collections.Generic;
using System.Text;

namespace BankAccountChangeCategory
{
    class StoreAccount : Account
    {
        public string StoreName { get; set; }
        public AccountCategoryId AccountCategory { get; set; }

        public StoreAccount(string customerName) : base(customerName)
        {
            AccountCategory = AccountCategoryId.Basic;
        }

        public bool ChangeCategory(AccountCategoryId newCategory)
        {
            if (newCategory == AccountCategoryId.Lead &&
                Balance >= 10000)
            {
                return true;
            }

            else if (newCategory == AccountCategoryId.Senior &&
                    Balance >= 5000)
            {
                return true;
            }

            else if (newCategory == AccountCategoryId.Mid &&
                    Balance >= 1000)
            {
                return true;
            }
            else if (newCategory == AccountCategoryId.Basic &&
                    Balance >= 0)
            {
                return true;
            }

            return false;

        }
        public override string ToString()
        {
            return base.ToString() + "\n Store name: " + StoreName + " Account category: " + AccountCategory;
        }
    }
}