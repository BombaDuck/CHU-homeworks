public class CmEmployee2044 extends Object 
{
	private String firstName;
	private String lastName;
	private double grossSales;
	private double commissionRate;
	
	public CmEmployee2044(String first, String last,  double sales, double rate)
	{
		firstName = first;
		lastName = last;
		setGrossSales(sales);
		setCommissionRate(rate);
		
	}
	
	public void setFirstName(String first)
	{
		firstName = first;
	}
	
	public String getFirstName()
	{
		return firstName;
	}
	
	public void setLastName(String last)
	{
		lastName = last;
	}
	
	public String getLastName()
	{
		return lastName;
	}

	public void setGrossSales(double sales) 
	{
		// TODO Auto-generated method stub
		grossSales = (sales < 0.0) ? 0.0 : sales;
	}
	public double getGrossSales()
	{
		return grossSales;
	}
	
	public void setCommissionRate(double rate)
	{
		commissionRate = (rate > 0.0 && rate <1.0 ) ? rate : 0.0;
	}
	
	public double getCommissionRate()
	{
		return commissionRate;
	}
	
	public double earrings()
	{
		return getCommissionRate() * getGrossSales();
	}
	
	@Override
	public String toString()
	{
		return String.format("commission employee : %s %s \ngross sales: %.2f\ncommission rate: %.2f"
							,getFirstName(),getLastName(),getGrossSales(),getCommissionRate() );
	}
	
	
	
	
	
}
