int i = 0;

while(i < 10)
{
    i++;
    Console.WriteLine(DateTime.Now.ToString("Qual eh a Hora?") );
    Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") +" " + i);
}
