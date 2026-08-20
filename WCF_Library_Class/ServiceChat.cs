using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_Library_Class
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceChat" в коде и файле конфигурации.
    public class ServiceChat : IServiceChat
    {
        public double TASK(double a, double b, double c, double x)
        {
            double result = 0;
            for (int i = 1; i <= 5; i++)
            {
                int factorial = 1;
                for (int j = 1; j <= i; j++)
                {
                    factorial *= j;
                }
                result += (Math.Cos(Math.Pow(a * b, 2)) + Math.Sin(x) + (-Math.Pow(c, 3 / 4))) / factorial;
            }
            return result;
        }
    }
}
