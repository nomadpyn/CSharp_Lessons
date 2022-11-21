
Calendar nw = new Calendar();

nw.itsTime += Message;

nw.monthCount();

void Message(Months now)
{
    Console.WriteLine($"{now} начался. Сезон сменился,пора менять одежду и обувь");
}
enum Months : byte 
{ 
    Январь=1,
    Февраль,
    Март,
    Апрель,
    Май,
    Июнь,
    Июль,
    Август,
    Сентябрь,
    Октябрь,
    Ноябрь,
    Декабрь
}

