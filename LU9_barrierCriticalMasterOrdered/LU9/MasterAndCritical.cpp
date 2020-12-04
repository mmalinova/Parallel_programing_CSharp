#include <omp.h>
#include <stdio.h>

int main() {
	int N = 10;
	int a[10], i;

#pragma omp parallel 
	{

	//1: Perform the computation.
#pragma omp for
	for (i = 0; i < N; ++i) {
		printf_s("1: Thread: %d, multiplying a[%d]\n",
			omp_get_thread_num(), i);
		a[i] = i * i;
	}

	//2: Print intermediate results
#pragma omp master
	for (i = 0; i < N; ++i)
		printf_s("2: Thread: %d, a[%d] = %d\n",
			omp_get_thread_num(), i, a[i]);

	//Wait for the printing to end
#pragma omp barrier

	//3:Continue with the computation
#pragma omp for
	for (i = 0; i < N; ++i) {
		printf_s("3: Thread: %d, summing a[%d]\n",
			omp_get_thread_num(), i);
		a[i] += i;
	}
	}

	//4: Print final results
#pragma omp master
	for (i = 0; i < N; i++)
		printf_s("4: Thread: %d, a[%d] = %d\n",
		omp_get_thread_num(), i, a[i]);
}
