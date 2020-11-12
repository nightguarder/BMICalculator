using System;
using System.Drawing;
using System.Runtime.CompilerServices;
namespace priklad_3._2
{
    class BMICalc
    {
        static void Main(string[] args)
        {
            bool restartovat = true;
            while (restartovat)
            {
                Console.WriteLine("Program spočte Vaše BMI (Body Mass Index)");
                Console.WriteLine("Zadejte prosim Váš věk:");
                int vek = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zadejte Vaši tělesnou výšku v (cm): ");
                double vyska = Convert.ToDouble(Console.ReadLine());
                double vyskam = vyska / 100.0;                      //prevod cm do m
                Console.WriteLine("Zadejte Vaši tělesnou váhu (kg): ");
                double vaha = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Zadejte obvod pasu v (cm) " +" (pouze pro vypocet ABSI): ");
                double obvod = Convert.ToDouble(Console.ReadLine());
                                                                //dodelat pokud uzivatel nezada nic
                double bmi;
                bmi = vaha / (vyskam * vyskam);                 //vypocet bmi
                bmi = Math.Round(bmi, 2);                       //zaokrouhleni 2 des.mista

                double absi;
                double pas;
                double wc;
                double vysledek;
                wc = bmi / 3;
                Convert.ToInt32(wc);
                pas = vyska / 2;                              // vypocet ABSI
                vysledek = (wc * 2) * pas;                    // obvod pasu/ (bmi2/3) *(vyskam1/2) 
                absi = obvod / vysledek;
                Console.WriteLine("Údaje o uživateli: " + vek + " let, " + +vaha + " kg, " + " výška: " + vyska + " cm \n");

                Console.WriteLine("Vaše výsledné BMI= " + bmi + "\n" + "ABSI: " + absi + "\n");

                if (bmi < 15)
                {
                    Console.WriteLine("Těžká podvýživa :((");
                    Console.WriteLine("Vaše BMI: " + bmi + " Vaše hmotnost je velmi nízká. Vyhledejte prosím lékaře.\n");
                }

                else if (bmi < 18.5)
                {
                    Console.WriteLine("Podváha :( ");
                    Console.WriteLine("Vase BMI " + bmi + " Vaše hmotnost je velmi nízká. Prosím začněte jíst více tuků nebo bílkovin");

                }
                else if (bmi < 24.9)
                {
                    Console.WriteLine("Optimalní váha :) ");
                    Console.WriteLine("Vaše BMI " + bmi + " Vaše hmotnost je normální a nejzdravější, co se týče prognózy zdravotního stavu nebo délky života.\n");
                }
                else if (bmi < 29.9)
                {
                    Console.WriteLine("Mírná Nadváha :/ ");
                    Console.WriteLine("Vaše BMI " + bmi + " Nadváha je méně riziková než obezita. Mohou se ale objevovat zdravotní problémy.\n");
                }
                else if (bmi < 35.0)
                {
                    Console.WriteLine("Obezita :( Nejste v tom sám. V České republice trpí v současnosti obezitou 18 % žen a 20 % mužů. ");
                    Console.WriteLine("Vaše BMI " + bmi + " Nacházíte se v rizikové skupine. Změnte prosim svuj jidelnicek\n");

                }
                else if (bmi < 40.0)
                {
                    Console.WriteLine("Těžká obezita :((");
                    Console.WriteLine("Vaše BMI " + bmi + " Nachazíte se v rizikove skupině. Vyhledejte prosím lékaře\n");
                }
                else if (bmi < 10000)
                {
                    Console.WriteLine("Zadali jste špatnou hodnotu. Prosím restartujte aplikaci.");
                }
                Console.WriteLine("Přejete si pokračovat? ANO/NE");
                string s = Console.ReadLine();
                s = s.ToLower();
               
                if (s == "ano")
                {
                    restartovat = true;
                    Console.Clear();
                }
                else if (s == "yes")
                {
                    restartovat = true;
                    Console.Clear();
                }
                else if (s == "a")
                {
                    restartovat = true;
                    Console.Clear();
                }
                else 
                {
                    Console.WriteLine("Děkuji za použití BMI kalkulacky. Hezký den");
                    restartovat = false;
                }
            }

        }
    }
}
     
