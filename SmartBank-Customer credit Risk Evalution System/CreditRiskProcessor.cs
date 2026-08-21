using System;
public class CreditRiskProcessor
{
    public bool ValidateCustomerDetails(int age,string employmentType, double income,double dues, int creditScore, int defaults)
    {
        if(age<21 || age > 65)
        {
            throw new InvalidCreditDataException("Invalid Age");
        }
        if(employmentType != "Salaried" && employmentType != "Self-Employed")
        {
            throw new InvalidCreditDataException("Invalid employement type");
        }
        if(income < 20000)
        {
            throw new InvalidCreditDataException("Invalid Monthly income");
        }
        if(dues < 0)
        {
            throw new InvalidCreditDataException("Invalid Credit dues");
        }
        if(creditScore < 300 || creditScore > 900)
        {
            throw new InvalidCreditDataException("Invalid credit score");
        }
        if(defaults < 0)
        {
            throw new InvalidCreditDataException("Invalid default count");
        }

        return true;
    }
    public double CalculateCreditLimit(double income, double dues, int creditScore,int defaults)
    {
        double debtRatio = dues/(income * 12);

        if(creditScore< 600 || defaults >= 3 || debtRatio > 0.4)
        {
            return 50000;
        }

        if(creditScore >= 750 && defaults == 0 && debtRatio < 0.25)
        {
            return 300000;
        }

        return 150000;
    }
}