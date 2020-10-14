
public class BPCemployee2044 extends Cmployee2044
{
	private double baseSalary;
	
	public BPCemployee2044(String first,String last,String ssn,double sales,double rate,double salary)
	{
		super(first, last,ssn, sales, rate);
		setBaseSalary(salary);
	}
	
	public void setBaseSalary(double salary)
	{
		baseSalary = (salary<0.0) ? 0.0 : salary;
	}
	
	public double getBaseSalary()
	{
		return baseSalary;
	}
	
	@Override
	public double earnings()
	{
		return getBaseSalary() + super.earnings();
	}
	
	@Override
	public String toString()
	{
		return String.format("%s %s; %s: $%,.2f", 
							"base-Salaried",super.toString(),
							"base salary", getBaseSalary());
	}
	
	
}
