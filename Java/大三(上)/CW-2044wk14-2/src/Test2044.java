
public class Test2044 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		SaEmployee2044 saemployee = new SaEmployee2044("Bob","Lim","666-66-6666",800.00);
		Cmployee2044 cemployee = new Cmployee2044("Cynthia","Lim","878-87-8787",16.75,40);
		BPCemployee2044 bpcemployee = new BPCemployee2044("Hakuna","Matata","111-11-1111",5000,.04,300);
		
		System.out.printf("%s\n%s: $%, .2f\n\n",saemployee,"earned",saemployee.earnings());
		System.out.printf("%s\n%s: $%, .2f\n\n",cemployee,"earned",cemployee.earnings());
		System.out.printf("%s\n%s: $%, .2f\n\n",bpcemployee,"earned",bpcemployee.earnings());
		
		Employee2044[] employees = new Employee2044[3];
		
		employees[0] = saemployee;
		employees[1] = cemployee;
		employees[2] = bpcemployee;
		
		System.out.println("Employees processed polymorephically:\n");
		
		
		for(Employee2044 currentEmployee : employees)
		{
			System.out.println(currentEmployee);
			if(currentEmployee instanceof BPCemployee2044)
			{
				BPCemployee2044 employee = (BPCemployee2044) currentEmployee;
				employee.setBaseSalary(1.10*employee.getBaseSalary());
				
				System.out.printf("new base salary with 10%% increase is : $%,.2f\n",employee.getBaseSalary() );
			}
			System.out.printf("earned $%,.2f\n\n",currentEmployee.earnings());
		}
		
		for(int i=0;i<employees.length;i++)
			System.out.printf("Employee %d is a %s\n", i,employees[i].getClass().getName());
		
		
		
		
		
	}

}
