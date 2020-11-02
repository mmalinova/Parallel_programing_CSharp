#include <stdio.h>
#include <stdlib.h>
#include <omp.h>

void main(){
	int i, t, n = 10;

	printf("Num processors: %d\n", omp_get_num_procs());
	printf("Num max threads: %d\n", omp_get_max_threads());
	printf("Insert number of threads\n");
	scanf_s("%d", &t);

	if (t > omp_get_max_threads() * 2)
		printf("Error invalid number of threads");
	else
	{
		omp_set_num_threads(t);
		printf("Number of Threads: %d\n", omp_get_num_threads());
		printf("Time 1: %f\n", omp_get_wtime());
#pragma omp parallel for default(none) schedule(runtime) \
	private(i)shared(n)
		for (i = 0;  i < n; i++)
		{
			printf("Iteration %d executed by thread %d\n", i, omp_get_thread_num());
		} // End of parallel for
	}
	printf("Time 2: %f\n", omp_get_wtime());
	getchar();
}