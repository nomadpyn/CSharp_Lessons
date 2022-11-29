using System.Runtime.Serialization;
using System.Transactions;

// создаем класс PayBill с подключением сериализации и реализуем интерфейс ISerializable
[Serializable] 
public class PayBill: ISerializable
{
// поля класса PayBill
    public static bool format = false;
    public double Pay { get; set; }
    public byte Days { get; set; }
    public double FineForDay { get; set; }
    public byte FineDays { get; set; }
    public double Sum { get; set; }
    public double Fine { get; set; }
    public double BillToPay{ get; set; }

// конструктор без параметров для десериалиации
    public PayBill() { }

// конструктор для десериализации с проверкой на формат, необходимо считывать правильный файл bin
    private PayBill(SerializationInfo info, StreamingContext context)
    {
        if (PayBill.format)
        {
            this.Pay = info.GetDouble("Pay");
            this.Days = info.GetByte("Days");
            this.FineForDay = info.GetDouble("FineForDay");
            this.FineDays = info.GetByte("FineDays");
            this.Sum = info.GetDouble("Sum");
            this.Fine = info.GetDouble("Fine");
            this.BillToPay = info.GetDouble("BillToPay");
        }
        else
        {
            this.Pay = info.GetDouble("Pay");
            this.Days = info.GetByte("Days");
            this.FineForDay = info.GetDouble("FineForDay");
            this.FineDays = info.GetByte("FineDays");
        }
    }

// конструктор с параметрами
    public PayBill(double pay,byte days,double fineForDay, byte fineDays)
    {
        this.Pay = pay;
        this.Days = days;
        this.FineForDay= fineForDay;
        this.FineDays = fineDays;
    }

// метод расчета сумму на оплату со штрафом и без
    public void MakeBill()
    {
        this.Sum = this.Pay * this.Days;
        this.Fine = this.FineForDay * this.FineDays;
        this.BillToPay = this.Sum + this.Fine;
    }

// перегруженный метод вывора информации об объекте в консоль
    public override string ToString()
    {
        if (this.BillToPay != 0)
            return $"Сумма за услуги {this.Sum:F} руб\nШтраф {this.Fine:F} руб\nСумма к оплате {this.BillToPay:F} руб\n";
        else
            return "Счет на оплату не сформирован.\n";

    }

// описание пользовательской сериализации объекта
    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
        if (PayBill.format)
        {
            info.AddValue("Pay", this.Pay);
            info.AddValue("Days", this.Days);
            info.AddValue("FineForDay", this.FineForDay);
            info.AddValue("FineDays", this.FineDays);
            info.AddValue("Sum", this.Sum);
            info.AddValue("Fine", this.Fine);
            info.AddValue("BillToPay", this.BillToPay);
        }
        else
        {
            info.AddValue("Pay", this.Pay);
            info.AddValue("Days", this.Days);
            info.AddValue("FineForDay", this.FineForDay);
            info.AddValue("FineDays", this.FineDays);
        }
    }
}