#include <omp.h>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define CHUNKSIZE 10
#define N 100

int main(int argc, char *argv[])
{
	int nthreads;
	//omp_set_num_threads(4);
	int tid = 0, i, chunk;
	float a[N], b[N], c[N];

	//Some initializations
	for (i = 0; i < N; i++)
		a[i] = b[i] = i * 1.0;
	chunk = CHUNKSIZE;
	clock_t begin = clock();

#pragma omp parallel shared(a, b, c, nthreads, chunk) private(i, tid) num_threads(4) 
	{
		tid = omp_get_thread_num();
		if (tid == 0)
		{
			nthreads = omp_get_num_threads();
			printf("Number of threads = %d\n", nthreads);
		}
		printf("\tThread %d starting...\n", tid);

#pragma omp for schedule(dynamic, chunk)
		for (i = 0; i < N; i++) {
			c[i] = a[i] + b[i];
			printf("Thread %d: c[%d] = %f\n", tid, i, c[i]);
		}
	}//end of parallel section

	clock_t end = clock();
	double time_spent = (double)(end - begin) / CLOCKS_PER_SEC;
	printf("%f\n", time_spent);
}