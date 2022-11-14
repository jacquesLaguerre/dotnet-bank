public class BankAccount {

public string accountNumber {get;set;} //Gave it the type data string 
//public decimal balance {get; set;}

private decimal balance {get;set;}

public decimal getBalance(){
  return balance; 
}

public  void makeDeposit (decimal newDeposit) {
  if(newDeposit < 0 ){
    // balance = balance;
    throw new Exception (); 
  } else {
 balance = balance + newDeposit; 
}
}


//constructor
public BankAccount () {
  accountNumber = "unknown";
  balance = 100.01m;


}

public BankAccount(string newAccountName) {
  accountNumber = newAccountName;
  balance = 100.01m;
}

public BankAccount (decimal startingBalance) {
  accountNumber = "unknown";
  balance = 100.01m;

  if (startingBalance > 10000){
    balance = startingBalance + 2000;
  } else {
    balance = startingBalance + 100.01m;
  }
}

}

