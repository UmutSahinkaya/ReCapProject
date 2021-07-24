﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entitiy.Concrete;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Numarası => "+car.CarId+"\n olan \n"+car.ColorName+" Renkli\n"+car.BrandName+" Marka aracınız hazır.");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
            }
        }
    }
}
