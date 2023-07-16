System.Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 10000 && n > 100000){
    System.Console.WriteLine("Число не является пятизначным");
}
else{
    string SrtN = n.ToString();
    if(SrtN[0] == SrtN[4] && SrtN[1] == SrtN[3]){
        System.Console.WriteLine("Это полиндром");
    }
    else {
        System.Console.WriteLine("Это не полиндром");
    }
}



