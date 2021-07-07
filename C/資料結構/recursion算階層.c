int sum = 1;
void computevalue(int N)
{
	if(N < 0) return;
	if(N == 0)
	{
		printf("%d", sum);
		return;
	}
	
	sum = sum * N;
	N-=1;
	computevalue(N);
}
Int main()
{
	computevalue(N);
	return 0;
}
