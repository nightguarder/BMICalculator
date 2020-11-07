using System;
using System.Drawing;
using System.Runtime.CompilerServices;


namespace priklad_3._2

{
    class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Program spocte vase BMI (Body Mass Index)");
            Console.WriteLine("Zadejte prosim vas vek");
            int vek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Zadejte vaši telesnou vysku (cm): ");
            double vyska = Convert.ToDouble(Console.ReadLine());
            double vyskam = vyska / 100.0;                      //prevod cm do m
            Console.WriteLine("Zadejte vaši telesnou vahu (kg): ");
            double vaha = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Zadejte obvod pasu (cm):");
            double obvod = Convert.ToDouble(Console.ReadLine());


            

            double bmi;
            bmi = vaha / (vyskam * vyskam);                 //vypocet bmi
            bmi = Math.Round(bmi, 2);                       //zaokrouhleni 2 des.mista

            double absi;
            double pas;
            double wc;
            double vysledek;
            int mezisoucet;
            wc = bmi / 3;
            Convert.ToInt32(wc);
            pas = vyska / 2;                              // vypocet ABSI
            vysledek = (wc * 2) * pas;                    // obvod pasu/ (bmi2/3) *(vyskam1/2) 
            absi = obvod / vysledek;
            Console.WriteLine("Údaje o uzivateli: " + vek + " let, " + +vaha + " kg, " + " vyska: " + vyska + " cm \n");

            Console.WriteLine("Vase vysledne BMI: " +  bmi + " ABSI: " + absi);
            
            

            if (bmi < 18.5)
            {
                Console.WriteLine("Tezka podvýživa :(( ");
                Console.WriteLine("Vase BMI " +bmi + " Vaše hmotnost je velmi nízká. Vyhledejte prosím lékaře.\n");

            }
            if (bmi > 18.55 && bmi < 24.9)
            {
                Console.WriteLine("Optimalní váha :) ");
                Console.WriteLine("Vaše BMI " +bmi + " Vaše hmotnost je normální a nejzdravější, co se týče prognózy zdravotního stavu nebo délky života.\n");
            }
            if (bmi >25.0 && bmi < 29.9)
            {
                Console.WriteLine("Mírná Nadváha :/ ");
                Console.WriteLine("Vaše BMI " + bmi + " Nadváha je méně riziková než obezita. Mohou se objevovat zdravotní problémy.\n");
            }
            if (bmi>30.0&& bmi< 35.0)
            {
                Console.WriteLine("Obezita :( Nejste v tom sám. V České republice trpí v současnosti obezitou 18 % žen a 20 % mužů. ");
                Console.WriteLine("Vaše BMI " + bmi + " Nacházíte se v rizikové skupine. Změnte prosim svuj jidelnicek\n");
                
            }
            if (bmi > 35.0 && bmi < 40.0)
            {
                Console.WriteLine("Tezka obezita :((");
                Console.WriteLine("Vaše BMI " +bmi + " Nachazíte se v rizikove skupine. Vyhledejte prossim lekaře\n");
            }
            Console.WriteLine("Děkuji za pouziti BMI kalkulacky. Hezký den");
            Console.ReadKey();
        }
        
    }
}
     
