#include <stdio.h>
#include <stdlib.h>
#include <omp.h>
#include <math.h>
//#include <time.h>

int main(void) {

	int NUMBER = 50;
	int sum = 0;

#pragma omp parallel for reduction(+ : sum)

	for (int i = 0; i < NUMBER; ++i) {
		sum += i;
		printf("Iteraction %d executed by thread %d, temporal sum value is %d\n", i, omp_get_thread_num(), sum);
	}

	printf("Sum is %d\n", sum);
	system("pause");
}