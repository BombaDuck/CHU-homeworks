import java.util.*;
public class Read2044 
{

	public static void main(String[] args) throws Exception
	{
		Scanner input = new Scanner(System.in);
		
		Formatter output = new Formatter("students.txt");
		
		String studentName;
		int score1;
		int score2;
		int score3;
		System.out.println("Type <ctrl> z then press Enter to leave ");
		System.out.println("Plz enter by the order ");
		System.out.println("Enter student name : ");
		System.out.println("Enter student score 1 : ");
		System.out.println("Enter student score 2 : ");		
		System.out.println("Enter student score 3 : ");
		
		while(input.hasNext())
		{
			studentName = input.next();
			score1 = input.nextInt();
			score2 = input.nextInt();
			score3 = input.nextInt();
			
			if(score1 >=0 && score2 >=0 && score3 >=0)
			{
				output.format("%s %d %d %d\n", studentName,score1,score2,score3);
				System.out.printf("%s %d %d %d\n", studentName,score1,score2,score3);
			}
			else
			{
				System.out.println("Scores must be greater than 0.");
			}
		}
		output.close();

		
		
		
		
	}

}
