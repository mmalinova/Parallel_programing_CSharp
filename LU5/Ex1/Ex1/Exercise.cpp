#include <stdio.h>
#include <stdlib.h>
#include <omp.h>

int main(void) {
	int i, x = 44;

	printf_s("Value of x before parallel for region: %d\n", x);

#pragma omp parallel for lastprivate(x)
	for(i = 0; i <= 10; i++) {
		x = i;
		printf_s("Thread number: %d         x: %d\n", omp_get_thread_num(), x);
	}

	printf_s("Value of x after parallel for region: %d\n", x);
	system("pause");
}