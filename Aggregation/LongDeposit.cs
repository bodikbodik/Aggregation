namespace Aggregation
{
    public class LongDeposit : Deposit
    {
        public LongDeposit(decimal amount, int period) : base (amount, period)
        {

        }

        public override decimal Income()
        {
            decimal tempAmount = Amount;

            for(int i = 7; i <= Period; i++)
            {
                tempAmount = tempAmount + tempAmount / 100 * 15;
                
            }
            return tempAmount - Amount;
        }

    }

}