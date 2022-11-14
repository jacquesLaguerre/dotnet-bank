Console.WriteLine("Welcome to the Bank");

BankAccount account = new BankAccount(1100); //passed to the different methods 

// account.balance = 100;
try {
account.makeDeposit(-1);
} catch (Exception ex) {
  Console.WriteLine(ex.Message);
}


Console.Write($"Your balance is: {account.getBalance()} ");
Console.WriteLine($"Account Number: {account.accountNumber}"); //template literal with C# $ at the start.

// public class BankAccount {

// public string accountNumber {get;set;}= ""; //Gave it the type data string 
// public decimal balance {get;set;}= 0;

// }
