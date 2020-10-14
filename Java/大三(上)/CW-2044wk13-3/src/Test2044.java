
public class Test2044 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
	
		CmEmployee2044 employee = new CmEmployee2044("Lim","Bob",10000,.06);
		
		System.out.println("Employee information obtained by get methods: \n");
		System.out.printf("First name is %s\n",employee.getFirstName() );
		System.out.printf("Last name is %s\n",employee.getLastName());
		System.out.printf("Gross sales is",employee.getGrossSales());
		System.out.printf("Commission rate is %s\n",employee.getCommissionRate());
		employee.setGrossSales(500);
		employee.setCommissionRate(.1);
		
		System.out.printf("\nUpdated employee information obtained by toString :\n\n%s\n",employee);
		
		
	}

}
