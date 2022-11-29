using System.Transactions;

[Serializable]
public class PayBill
{
    public double Pay { get; set; }
    public byte Days { get; set; }
    public double FineForDay { get; set; }
    public byte FineDays { get; set; }
    public double Sum { get; set; }
    public double Fine { get; set; }
    public double BillToPay{ get; set; }

    public PayBill(double pay,byte days,double fineForDay, byte fineDays)
    {
        this.Pay = pay;
        this.Days = days;
        this.FineForDay= fineForDay;
        this.FineDays = fineDays;
    }
    public void MakeBill()
    {
        this.Sum = this.Pay * this.Days;
        this.Fine = this.FineForDay * this.FineDays;
        this.BillToPay = this.Sum + this.Fine;
    }
    public override string ToString()
    {
        if (this.BillToPay != 0)
            return $"Сумма за услуги {this.Sum} руб\nШтраф {this.Fine} руб\nСумма к оплате {this.BillToPay} руб";
        else
            return "Счет на оплату не сформирован.";
    }


}