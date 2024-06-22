

using System.Net;
using Figgle;

Console.Clear();
string[] tipos =
{
   "O Zumbi",
   "O Assassino",
   "O Psicopata",
   "O Palhaço",
   "O Carniceiro",
   "O Matador",
   "O Vampiro",
   "O Maluco",
   "O Vingador",
   "O Monstro",
   "O Bruxo",
   "O Demonio"
};
string[] variedades =
{
   "Endiabrado",
   "Radioativo",
   "Endemoniado",
   "Vermelho",
   "Possuido",
   "Macabro",
   "Sem cabeca",
   "Cadeirante",
   "Sem olhos",
   "Oculto",
   "Caido",
   "Amaldiçado",
   "Invocado",
   "Desconhecido",
   "Esquecido",
   "Costurado",
   "Anormal",
   "Lugebre",
   "Tenebroso",
   "Imortal",
   "Burro",
   "Do inferno",
   "Abandonado",
   "Desconhecido",
   "Do cemiterio",
   "Sem lugar",
   "Da lua cheia",
   "Do velho poço",
   "Do porão",
   "Sanguinario",
   "Pertubado",
};
 
string tipo, variedade;
 
int mes, dia;
 
 
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(":::::Noite de Terror:::::");
Console.ResetColor();
 
 
Console.Write("Qual o dia do aniversario da vitima?(1 até 31):");
dia = Convert.ToInt32(Console.ReadLine());
if (dia < 1 || dia > 31)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Esse dia não é compatível");
    Console.ResetColor();
    return;
}
 
Console.Write("Qual o mes do aniversario da vitima?(1 até 12):");
mes = Convert.ToInt32(Console.ReadLine());
if (mes < 1 || mes > 12)

{  
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Esse mês não é compatível");
    Console.ResetColor();
    return;
}

if (mes<8&&dia>30&&mes%2==0)
{Console.WriteLine("Dia não bate com mes!");
return;}
else if(mes==2&&dia>29)
{Console.WriteLine("Dia não bate com mes!");
return;}
if (mes>7&&dia>30&&mes%2==1)
{Console.WriteLine("Dia não bate com mes!");
return;}
 
tipo = tipos[mes - 1];
variedade = variedades[dia - 1];
 Console.ForegroundColor = ConsoleColor.Blue;
Console.Write($"{tipo} {variedade}");
Console.ResetColor();
 
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n\n"+FiggleFonts.Big.Render("Obrigado."));
Console.ResetColor();


