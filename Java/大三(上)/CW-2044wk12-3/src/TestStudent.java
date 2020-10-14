
public class TestStudent 
{
	
	
	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		System.out.printf("Students amount : %d\n", Student.getCount());
		
		Student st1 = new Student("Desmond","Chong","History");
		Student st2 = new Student("Calyn","Koh","Foreign Lenguage");
		Student st3 = new Student("Cynthia","Lim","Design");
		
		System.out.println("\nStudents : ");
		
		System.out.printf("via st1.getCount() : %d\n",st1.getCount());
		System.out.printf("via st2.getCount() : %d\n",st2.getCount());
		System.out.printf("via st3.getCount() : %d\n",st3.getCount());
		System.out.printf("via Student.getCount() : %d\n",Student.getCount());
		
		System.out.printf("v\nStudent 1: %-8s %-8s %s\nStudent 2: %-8s %-8s %s\nStudent 3: %-8s %-8s %s\n",
				st1.getFirstName(),st1.getLastName(),st1.getMajor(),
				st2.getFirstName(),st2.getLastName(),st2.getMajor(),
				st3.getFirstName(),st3.getLastName(),st3.getMajor());
		
		st1 = null;
		st2 = null;
		st3 = null;
	}

}
