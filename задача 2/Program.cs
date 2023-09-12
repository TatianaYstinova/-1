using задача_2;
int sum = CalculateЕTheSizeOfBankDeposit.ReadSum();
int durationYears = CalculateЕTheSizeOfBankDeposit.ReadDurationYears();
int percent = CalculateЕTheSizeOfBankDeposit.ReadPercent();

int AmountOfSavings = CalculateЕTheSizeOfBankDeposit.AmountOfSavings(durationYears, sum,  percent);
Console.WriteLine(AmountOfSavings);

