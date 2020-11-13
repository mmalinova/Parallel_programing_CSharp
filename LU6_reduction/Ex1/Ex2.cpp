#include <stdio.h>
#include <stdlib.h>
#include <omp.h>
#include <math.h>
#include <time.h>

/*int main(void) {

	int NUMBER = 100;
	int sum = 0, i;

#pragma omp parallel for reduction(+ : sum)

	for (i = 2; i <= NUMBER; ++i) {
		bool isPrimeNumber = true;
		for (int j = 2; j <= NUMBER; ++j) {
			if (i != j && i % j == 0) {
				isPrimeNumber = false;
				printf("\tNumber %d is NOT prime number!\n", i);
				break;
			}
		}
		if (isPrimeNumber) {
			printf("\tNumber %d IS prime number!\n", i);
			sum += i;
		}
		printf("Iteraction %d executed by thread %d, temporal sum value is %d\n",
			i, omp_get_thread_num(), sum);
	}

	printf("Sum is %d\n", sum);
	system("pause");
}
*/