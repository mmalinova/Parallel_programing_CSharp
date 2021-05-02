# Parallel_programing_CSharp
Some code for parallel programming, measurement of execution time and division of tasks into separate threads of the processor.

The context of each folder is as follow:

## LU1

 - Ex1 - An algorithm that traverses all elements of an array and calculate Math.Pow().
 - Ex2 - A problem that finds the product of two matrices with n number of elements. The task is realized by first using a sequential For loop and then using Parallel.For. Execution time is also measured in both cases.

## LU2

 - Ex1 - In this task we have a class bank account (Account), with a member variable mBalance -
the current account balance and the method method Withdraw100 (), which does not have the balance with 100. The problem solves the problem when two threads simultaneously withdraw money from this bank account, the balance in it remains correct.
 - Ex2 - A console application that sums each of the elements of a two-dimensional array of type double with a number of the same type. An array is initialized with random numbers. When traversing an array in the summation method, a message is displayed in the console with the thread name and the values of i and j only when i and j are divided by 100.
The summation is performed in a method to be called from 2 threads with different priority. The results of each thread are measured and compared.

## LU3

Demonstration for working with tasks in C #.

## LU3_2

 A program that divides the multiplication of an array of type double by a number of the same type into as many tasks as there are computer processors.
 
 ## LU_OpenMP

OpenMp private directive.

## LU5

OpenMp lastprivate directive.

## LU6_reduction

OpenMp reduction clause. 

## LU7

OpenMp firstprivate directive. 

## LU8

OpenMp schedule clause. 

## LU9_barrierCriticalMasterOrdered

OpenMp barrier, critical, master and order directives.

##LU10_MPI

Introduction to MPI programming with C#.
