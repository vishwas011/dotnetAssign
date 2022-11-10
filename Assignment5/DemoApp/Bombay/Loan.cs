namespace Bombay;

public abstract class Loan
{
	public double Principle {get; set;}
	public int Period {get; set;}

    public abstract double GetRate();

	public double GetEMI()
    {
		return Principle*(1+GetRate()*Period/100)/(12*Period);
	}

}
