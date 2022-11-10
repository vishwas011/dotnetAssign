namespace Bombay;

public class PersonalLoan :Loan , ITaxable
{
    private double Amount=base.GetPrinciple();

	public override double GetRate(){
		if(Amount<=500000)
			return 15;
		else
			return 16;
	}
	public double GetTax(){
		if(Amount>2000000)
			return 0.1;
		else
			return 0.07;
	}

    /*public PersonalLoan()
    {
        Amount=5000;
    }*/
}