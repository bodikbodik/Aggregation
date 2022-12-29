namespace Aggregation
{
    public class BaseDeposit : Deposit
    {
        public BaseDeposit(decimal amount, int period) : base (amount, period )
        { 

        }

        public override decimal Income()
        {
            decimal tempAmount = Amount;
   
            for (int i = 1; i <= Period; i++)
            {
                tempAmount = tempAmount + tempAmount  / 100 * 5;
                
            }
            return tempAmount - Amount;
        }
    }
}