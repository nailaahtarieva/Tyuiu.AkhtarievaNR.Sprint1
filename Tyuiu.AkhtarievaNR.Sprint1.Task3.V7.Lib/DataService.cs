﻿using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.AkhtarievaNR.Sprint1.Task3.V7.Lib
{
    public class DataService : ISprint1Task3V7
    {
        public double VerstsToKilometers(double verst)
        {
            return Math.Round(verst * 1.0668, 3);
        }
    }
}
