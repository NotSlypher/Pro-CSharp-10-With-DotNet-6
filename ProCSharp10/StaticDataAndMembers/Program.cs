using StaticDataAndMembers;

Console.WriteLine("Stalic data");
SavingsAccount s1 = new SavingsAccount(50);
SavingsAccount s2 = new SavingsAccount(100);

// Print the current interest rate.
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

// Make a new object, this does NOT change the interest rate.
SavingsAccount s3 = new SavingsAccount(10000.75);
Console.WriteLine("Interest Rate is: {0}", SavingsAccount.GetInterestRate());

Console.WriteLine(SavingsAccount.currInterestRate);

// Static Class

TimeUtil.PrintTime();
TimeUtil.PrintDate();