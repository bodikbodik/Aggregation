namespace Aggregation
{

    public class SpecialDeposit : Deposit
    {
        public SpecialDeposit(decimal amount, int period) : base (amount, period)
        {

        }

        public override decimal Income()
        {
            
                decimal tempAmount = Amount;
                
                for (int i = 1; i <= Period; i++)
                {
                tempAmount = tempAmount + tempAmount  / 100 * i;
                    
                }
                return tempAmount - Amount;
            
        }

    }
}