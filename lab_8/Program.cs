using System;
using System.Collections.Generic;
using System.Threading;

public class Program
{

	// lock (locker) {counter++; }
	public static int number = 0;
	public static volatile bool limit = true;

	public static bool isPrimeNumber(long number)
	{
		long limit = (long)Math.Floor(Math.Sqrt(number));
		for (int i = 2; i <= limit; ++i)
		{
			if (number % i == 0)
			{
				return false;
			}
		}
		return number >= 2;
	}

	public static void Main(string[] args)
	{


		HashSet<long> numbers = new HashSet<long>();
		//numbers.Add(i)

		Object locker = new Object();

		Thread thread1 = new Thread(() =>
		{

			for (int i = 0; limit; i += 4)
			{
				if (isPrimeNumber(i))
				{

					lock (locker) { numbers.Add(i); }

				}
			}
		});

		Thread thread2 = new Thread(() =>
		{

			for (int i = 1; limit; i += 4)
			{
				if (isPrimeNumber(i))
				{

					lock (locker) { numbers.Add(i); }


				}
			}
		});
		Thread thread3 = new Thread(() =>
		{

			for (int i = 2; limit; i += 4)
			{
				if (isPrimeNumber(i))
				{

					lock (locker) { numbers.Add(i); }

				}
			}
		});
		Thread thread4 = new Thread(() =>
		{

			for (int i = 3; limit; i += 4)
			{
				if (isPrimeNumber(i))
				{

					lock (locker) { numbers.Add(i); }

				}
			}
		});

		thread1.Start(); thread2.Start(); thread3.Start(); thread4.Start();

		Thread.Sleep(10000);
		limit = false;

		thread1.Join(); thread2.Join(); thread3.Join(); thread4.Join();

		Console.WriteLine("DONE");
		Console.WriteLine(numbers.Count);

	}
}
