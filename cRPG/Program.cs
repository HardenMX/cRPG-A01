
//await Task.Delay(2000);
//MyNamespace.MyClass.MyMethod();

string[] charStatsNames = ["Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"];
int[] char1Stats = [12,17,14,7,11,13];
Random dice = new Random();

statMethods.StatModifierGenerator(char1Stats);

public class statMethods()
{
    public static void StatModifierGenerator(int[] charStats)
    {
        int[] charStatsModifiers = [0,0,0,0,0,0];
        for (int i = 0; i < charStats.Length; i++)
        {
            charStatsModifiers[i] = (charStats[i] - 10) / 2;
            //Console.WriteLine(charStatsModifiers[i]);
        }
    }
 }

namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
        }
    }
}

 



