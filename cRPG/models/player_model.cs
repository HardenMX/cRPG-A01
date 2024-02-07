

public class playerModel {
    string playerName = "";
    string playerClass = "";
    int[] playerStats = [0, 0, 0, 0, 0, 0];

    static void GenerateStatModifier (int[] stats) {

         int[] statsHolder = [0,0,0,0,0,0];
        for (int i = 0; i < stats.Length; i++)
        {
            statsHolder[i] = (stats[i] - 10) / 2;
            Console.WriteLine(statsHolder[i]);
        }
    }

}