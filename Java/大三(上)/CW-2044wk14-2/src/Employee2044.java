
public abstract class Employee2044 
{
	private String firstName;
	private String lastName;
	private String ssNumber;
	
	public Employee2044(String first, String last, String ssn)
	{
		firstName = first;
		lastName = last;
		ssNumber = ssn;	
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
	public void setSSNumber(String ssn)
	{
		ssNumber = ssn;
	}
	public String getSSNumber()
	{
		return ssNumber;
	}
	
	
	@Override
	public String toString()
	{
		return String.format("%s %s\n Social security number: %s", getFirstName(),getLastName(),getSSNumber());
		
	}
	
	public abstract double earnings();
}
