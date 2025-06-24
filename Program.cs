int i = 0;

while(i < 100000)
{
    i++;
    Console.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") +" " + i);
}
