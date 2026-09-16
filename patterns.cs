
string bankRecords = """
    DEPOSIT,   10000, Initial balance
    DEPOSIT,     500, regular deposit
    WITHDRAWAL, 1000, rent
    DEPOSIT,    2000, freelance payment
    WITHDRAWAL,  300, groceries
    DEPOSIT,     700, gift from friend
    WITHDRAWAL,  150, utility bill
    DEPOSIT,    1200, tax refund
    WITHDRAWAL,  500, car maintenance
    DEPOSIT,     400, cashback reward
    WITHDRAWAL,  250, dining out
    DEPOSIT,    3000, bonus payment
    WITHDRAWAL,  800, loan repayment
    DEPOSIT,     600, stock dividends
    WITHDRAWAL,  100, subscription fee
    DEPOSIT,    1500, side hustle income
    WITHDRAWAL,  200, fuel expenses
    DEPOSIT,     900, refund from store
    WITHDRAWAL,  350, shopping
    DEPOSIT,    2500, project milestone payment
    WITHDRAWAL,  400, entertainment
    """;

double currentBalance = 0.0;
foreach (var transaction in TransactionRecords(bankRecords))
{
    var details = transaction switch
    {
        Deposit d => (Type: "DEPOSIT", Amount: d.Amount),
        Withdrawal w => (Type: "WITHDRAWAL", Amount: w.Amount),
        _ => (Type: "INVALID", Amount: 0.0),
    };

    currentBalance += (details.Type is "WITHDRAWAL") ? -details.Amount : details.Amount;

    Console.WriteLine($"{details.Type} => Parsed Amount: {details.Amount}, New Balance: {currentBalance}");
}


static IEnumerable<object?> TransactionRecords(string inputText)
{
    var reader = new StringReader(inputText);
    string? line;
    while ((line = reader.ReadLine()) is not null)
    {
        string[] parts = line.Split(',');

        string? transactionType = parts[0]?.Trim();
        if (double.TryParse(parts[1].Trim(), out double amount))
        {
            // Update the balance based on transaction type
            if (transactionType?.ToUpper() is "DEPOSIT")
                yield return new Deposit(amount, parts[2]);
            else if (transactionType?.ToUpper() is "WITHDRAWAL")
                yield return new Withdrawal(amount, parts[2]);
        }
        else
        {
            yield return (TransactionType.Invalid, 0.0);
        }
    }
}

public enum TransactionType
{
    Deposit,
    Withdrawal,
    Invalid
}


public record Deposit(double Amount, string description);
public record Withdrawal(double Amount, string description);