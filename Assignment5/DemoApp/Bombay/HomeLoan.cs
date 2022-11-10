namespace Bombay;

public class HomeLoane :Loan, IDiscountable
{
    public double Amount=base.GetPrinciple();
	public override double GetRate(){
		if(Amount<=200000)
			return 10;
		else
			return 11;
	}
	public double GetDiscount(){
		if(Amount>2500000)
			return 0.2;
		else
			return 0.1;
	}
/*
	public HomeLoane(double Period,double Principle,double Amount):base(Period,Principle)
	{
		this.Amount=Amount;
	}

	public HomeLoane():base()
	{
		Amount=2000;
	}*/
}