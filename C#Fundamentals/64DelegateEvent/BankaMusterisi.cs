namespace _64DelegateEvent
{
    class BankCustomer
    {

        public delegate void Delegate();
        public event Delegate BalanceDroppedBelowZero;
        private decimal _balance;
        public decimal Balance
        {
            get
            {
                return _balance;
            }
            private set
            {
                _balance = value;
                if (_balance < 0)
                {
                    if (BalanceDroppedBelowZero != null)
                    {
                        BalanceDroppedBelowZero();
                    }
                }
            }
        }

        private decimal _credit;
        public decimal Credit
        {
            get
            {
                return _credit;
            }
            set
            {
                _credit = value;
                Balance = Credit - Debt;
            }
        }

        private decimal _debt;
        public decimal Debt
        {
            get
            {
                return _debt;
            }
            set
            {
                _debt = value;
                Balance = Credit - Debt;
            }
        }
    }
}
