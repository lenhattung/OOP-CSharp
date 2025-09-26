using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Money
{
    public decimal Amount { get; private set; }
    public string Currency { get; private set; }

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    // Cộng tiền (cùng loại tiền tệ)
    public static Money operator +(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
            throw new InvalidOperationException("Không thể cộng hai loại tiền tệ khác nhau");

        return new Money(m1.Amount + m2.Amount, m1.Currency);
    }

    // Trừ tiền
    public static Money operator -(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
            throw new InvalidOperationException("Không thể trừ hai loại tiền tệ khác nhau");

        return new Money(m1.Amount - m2.Amount, m1.Currency);
    }

    // Nhân với số
    public static Money operator *(Money money, decimal multiplier)
    {
        return new Money(money.Amount * multiplier, money.Currency);
    }

    // So sánh lớn hơn
    public static bool operator >(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
            throw new InvalidOperationException("Không thể so sánh hai loại tiền tệ khác nhau");

        return m1.Amount > m2.Amount;
    }

    // So sánh nhỏ hơn (BẮT BUỘC khi có >)
    public static bool operator <(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
            throw new InvalidOperationException("Không thể so sánh hai loại tiền tệ khác nhau");

        return m1.Amount < m2.Amount;
    }

    public override string ToString()
    {
        return $"{Amount:C} {Currency}";
    }
}