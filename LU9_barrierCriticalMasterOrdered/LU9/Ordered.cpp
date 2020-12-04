#include <omp.h>
#include <stdio.h>

/*int main() {

#pragma omp parallel for ordered
	for (int i = 0; i <= 100; ++i) {
		if (i % 2) {

#pragma omp ordered
			printf_s("Iteration: %d, Thread: %d\n",
				i, omp_get_thread_num());
		}
	}
}
*/