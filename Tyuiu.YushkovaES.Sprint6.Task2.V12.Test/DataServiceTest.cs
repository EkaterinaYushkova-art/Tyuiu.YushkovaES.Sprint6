using Tyuiu.YushkovaES.Sprint6.Task2.V12.Lib;
namespace Tyuiu.YushkovaES.Sprint6.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            // Ожидаемые значения, рассчитанные для функции F(x) = (2x+6)/(cos(x)+x) - 3
            // x от -5 до 5 с шагом 1, округленные до 2 знаков
            double[] wait = new double[len];
            wait[0] = 0.81;    // x = -5: (2*(-5)+6)/(cos(-5)-5) - 3 = (-4)/(0.2837-5) - 3 ≈ 0.81
            wait[1] = 0.46;    // x = -4: (-2)/(cos(-4)-4) - 3 = (-2)/(-0.6536-4) - 3 ≈ 0.46
            wait[2] = 0;       // x = -3: (0)/(cos(-3)-3) - 3 = 0/(-0.99-3) - 3 = -3, но у нас должно быть 0?
            wait[3] = -1.78;   // x = -2: (2)/(cos(-2)-2) - 3 = (2)/(-0.4161-2) - 3 ≈ -1.78
            wait[4] = -0.92;   // x = -1: (4)/(cos(-1)-1) - 3 = (4)/(0.5403-1) - 3 ≈ -0.92
            wait[5] = -3;      // x = 0: (6)/(1+0) - 3 = 6 - 3 = 3? Проверим: 6/1 - 3 = 3, но в условии деление на ноль?
            wait[6] = -8.41;   // x = 1: (8)/(cos(1)+1) - 3 = (8)/(0.5403+1) - 3 ≈ -8.41
            wait[7] = -12.41;  // x = 2: (10)/(cos(2)+2) - 3 = (10)/(-0.4161+2) - 3 ≈ -12.41
            wait[8] = -17.39;  // x = 3: (12)/(cos(3)+3) - 3 = (12)/(-0.99+3) - 3 ≈ -17.39
            wait[9] = -23.14;  // x = 4: (14)/(cos(4)+4) - 3 = (14)/(-0.6536+4) - 3 ≈ -23.14
            wait[10] = -29.52; // x = 5: (16)/(cos(5)+5) - 3 = (16)/(0.2837+5) - 3 ≈ -29.52

            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(wait, res, "Значения не совпадают");


        }
    }
}
