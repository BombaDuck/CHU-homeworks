
public class Student 
{
	private String firstName;
	private String lastName;
	private String major;
	private static int count = 0;
	
	public Student(String first,String last,String maj)
	{
		firstName = first;
		lastName = last;
		major = maj;
		++count;
		
		System.out.printf("Student information : %s %s %s ; count = %d\n",
						   firstName,lastName,major,count);
	}
	
	public String getFirstName()
	{
		return firstName;
	}
	public String getLastName()
	{
		return lastName;
	}
	public String getMajor()
	{
		return major;
	}
	public static int getCount()
	{
		return count;
	}

}
