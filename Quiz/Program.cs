using System;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("");
Console.WriteLine("                                            ██████  ██    ██ ██ ███████ ");
Console.WriteLine("                                           ██    ██ ██    ██ ██    ███  ");
Console.WriteLine("                                           ██    ██ ██    ██ ██   ███   ");
Console.WriteLine("                                           ██ ▄▄ ██ ██    ██ ██  ███    ");
Console.WriteLine("                                            ██████   ██████  ██ ███████ ");
Console.WriteLine("                                              ▀▀                       ");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("                                      Willkommen zu Anh Tu Tran's Mathe-Quiz");
Console.WriteLine("                              5 Questions total, Get 1 point for every correct answer.");
Console.WriteLine("");
Console.Write("                                              Press 'Enter' to start!");
Console.ReadLine();
Console.Clear();

int points = 1;

Console.WriteLine("");
Console.WriteLine("                                                    What is 2+2?");
Console.WriteLine("");
Console.WriteLine("                                                   A)3   B)5   C)4");
Console.WriteLine("                                                       Answer:");
string answer1 = Console.ReadLine().ToLower();
Console.Clear();
if (answer1 == "4")
{
Console.WriteLine("4 is correct!");
Console.WriteLine();
Console.WriteLine("Press 'Enter' to continue");
Console.ReadLine();
}
else if (answer1 == "5")
{
Console.WriteLine("5 is incorrect");
System.Console.WriteLine();
Console.WriteLine("Press 'Enter' to continue");
Console.ReadLine();
Environment.Exit(0);
}
else if (answer1 == "3")
{
Console.WriteLine("3 is incorrect");
System.Console.WriteLine();
Console.WriteLine("Press 'Enter' to exit");
Console.ReadLine();
Environment.Exit(0);
}
else
{
Console.WriteLine("Your brain could not process this question");
System.Console.WriteLine();
System.Console.WriteLine("Press 'Enter' to exit");
Console.ReadLine();
Environment.Exit(0);
}
Console.WriteLine("")

