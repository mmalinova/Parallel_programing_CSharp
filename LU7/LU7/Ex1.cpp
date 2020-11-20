#include <stdio.h>
#include <stdlib.h>
#include <omp.h>
#include <math.h>
#include <time.h>

int main(int argc, char** argv) {
	//number of iterations
	int niter = 1000000;
	//x,y value for the random coordinate
	double x, y;
	int i; // loop counter
	int count = 0; // holds the number of good coordinates
	double pi, z;
	int numthreads = 16;

#pragma omp parallel firstprivate(x, y, z, i) reduction(+ : count) num_threads(numthreads)
	{
		printf("hello\n");
		//give a random seed
		srand((int)time(NULL) ^ omp_get_thread_num());

		for (i = 0; i < niter; ++i) {
			//give x and y random values
			x = (rand() % 10000) / 10000.0;
			y = (rand() % 10000) / 10000.0;
			z = sqrt((x*x) + (y*y));
			//check if point is inside circle, if so add to counter
			if (z <= 1.0)
			{
				++count;
			}
		}
	}

	pi = 4.0 * ((double)count / (double)(niter*numthreads));
	printf("Pi: %f\n", pi);

	return 0;
}
