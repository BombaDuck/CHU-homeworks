
public class SaEmployee2044 extends Employee2044
{
	private double weeklySalary;
	
	public SaEmployee2044(String first, String last, String ssn, double salary)
	{
		super(first,last,ssn);
		setWeeklySalary(salary);
	}
	
	public void setWeeklySalary(double salary)
	{
		weeklySalary = salary < 0.0 ? 0.0 : salary;
	}
	public double getWeeklySalary()
	{
		return weeklySalary;
	}
	
	@Override
	public double earnings()
	{
		return getWeeklySalary();
	}
	
	@Override
	public String toString()
	{
		return String.format("Salaried employee: %s\n%s: $%,.2f", super.toString(),"weekly salary",getWeeklySalary());
	}
}
