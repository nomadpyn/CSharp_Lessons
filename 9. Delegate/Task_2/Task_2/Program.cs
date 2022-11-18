
Data A = new Data();

showData<int> del1 = A.dataInt;
del1(34);
showData<double> del2 = A.dataDouble;
del2(3.25345345);
showData<decimal> del3 = A.dataDecimal;
del3((decimal)17.4234);
showData<char> del4 = A.dataChar;
del4('f');
showData<string> del5 = A.dataString;
del5("hello");


delegate void showData<T>(T a);