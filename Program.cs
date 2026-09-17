int ar = 0;

Console.WriteLine("Kérem a vásárló nevét: ");

string vnev = Console.ReadLine();


Console.WriteLine("Kérem a vásárló életkorát(év)");
int Vkor = int.Parse(Console.ReadLine());

var van = true;

Console.WriteLine("Van Diák igazolvány?(1=igen)");
var igazolv = int.Parse(Console.ReadLine());
var kedvezmeny = true;
if (igazolv == 1)
{
    van = true;
}
else
{
    van = false;
}
if (van == true){
    Console.WriteLine("A vásárló diák, kedvezményes jegyárat kap.");

};



Console.WriteLine("A jegy ára:");
decimal Jegyar = decimal.Parse(Console.ReadLine());

int Popcornar = 1500;
Console.WriteLine("Popcorn mennyisége:");
decimal Popcar = decimal.Parse(Console.ReadLine());

Popcornar = Convert.ToInt32(1500 * Popcar);

int osszeg1 = (int)Jegyar + Popcornar;

if (igazolv == 1)
{
    int osszeg = (int)Jegyar + Popcornar+((int)Jegyar + Popcornar/100*20);
    Console.WriteLine($"Az összeg: {osszeg}");
}
;