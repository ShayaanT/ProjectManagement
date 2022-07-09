using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProjectManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Random z = new Random();
            int code = z.Next(1000, 9999);
            int Selection1;
            int Selection2;
            int Selection3 = 0;
            string Selection4;
            int Selection5 = 0;
            int Selection6 = 0;
            string Selection7;
            int Selection8 = 0;
            int Selection9 = 0;
            string Selection10;
            int Selection11 = 0;
            int Selection12 = 0;
            string Selection13;
            int Selection14 = 0;
            int Selection15 = 0;
            int Selection16 = 0;
            double Selection26 = 0;
            double Selection28 = 0;
            string Selection17;
            int Selection18 = 0;
            int Selection19 = 0;
            string Selection20;
            int Selection21 = 0;
            int Selection22 = 0;
            string Selection23;
            int Selection24 = 0;
            double[] price1 = { 0, 2.99, 3.89, 3.99, 3.99, 2.49, 1.49, 1.49, 1.49, 2.39, 2.39, 2.39, 5.19, 5.19, 5.19, 4.69, 4.69, 4.69, 4.69, 4.69, 4.69, 5.19, 2.69, 1.99, 3.69 };
            double[] cals1 = { 0, 360, 290, 440, 310, 370, 320, 330, 330, 330, 370, 380, 380, 550, 570, 570, 540, 550, 550, 600, 610, 620, 280, 160, 550 };
            double[] price2 = { 0, 5.29, 6.99, 6.39, 6.89, 5.89, 8.39, 7.69, 2.99, 2.49, 3.79, 4.79 };
            double[] cals2 = { 0, 560, 730, 530, 610, 430, 830, 750, 420, 320, 400, 570 };
            double[] price3 = { 0, 1.99, 0.99, 0.99, 2.89, 1.69, 4.49, 0.99, 1.49, 1.49, 1.49, 1.49, 1.49 };
            double[] cals3 = { 0, 150, 40, 150, 350, 120, 870, 30, 380, 430, 440, 360, 440 };
            double[] price4 = { 0, 2.69, 2.69, 3.39, 3.39, 3.39, 3.39, 1.79, 2.59, 2.59, 2.59, 2.59, 0.99, 1.19 };
            double[] cals4 = { 0, 340, 340, 670, 570, 540, 600, 240, 760, 750, 740, 740, 25, 270 };
            double[] price5 = { 0, 1.79, 1.79, 2.99, 3.29, 3.29, 1.49, 2.99, 3.29, 3.29, 3.29, 3.49, 3.89, 1.39, 1.99, 2.19, 2.99 };
            double[] cals5 = { 0, 4, 0, 130, 260, 260, 0, 170, 290, 300, 290, 380, 370, 3, 5, 4, 400 };
            double[] price6 = { 0, 2.19, 2.24, 2.39, 2.79, 2.79, 3.34, 3.34, 3.34, 3.34, 3.34, 3.34, 3.34, 1.99, 1.99, 1.69, 1.69 };
            double[] cals6 = { 0, 0, 190, 170, 200, 180, 240, 260, 250, 260, 250, 260, 520, 180, 160, 110, 150 };
            double[] price7 = { 0, 4.79, 4.59, 4.59, 4.59, 3.99, 4.19, 3.34, 3.34, 3.34, 3.34, 3.34, 3.34, 1.99, 1.99, 1.69, 1.69 };
            double[] cals7 = { 0, 340, 440, 370, 660, 390, 520, 260, 250, 260, 250, 260, 520, 180, 160, 110, 150 };
            double PaymentMethod = 0;
            string VisaPaymentMethod = "t";
            int codeentered = 0;
            var miliseconds = 2000;
            double Selectioncals1 = 0;
            double Selectioncals2 = 0;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Clear();
            Console.WriteLine(" Your code is: " + code);
            Console.WriteLine();
            Console.WriteLine("                                                   Welcome to McDonalds! Please use the options below to help make your order. ");
            Console.WriteLine();
            Console.WriteLine();



            while (true)
            {
                ////This is the main menu
                Console.WriteLine("                                          ____________________________________________________________________________________________");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |           Please enter the number indicating which category you want to order from.        |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  1 -     Main Order                                        |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  2 -    Snacks/Sides                                       |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  3 - Desserts and Shakes                                   |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  4 -      Beverages                                        |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  5 -      Happy Meal                                       |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  6 - Proceed to payment                                    |");
                Console.WriteLine("                                         |                                                                                            |");
                Console.WriteLine("                                         |                                  7 -        Exit                                           |");
                Console.WriteLine("                                         |____________________________________________________________________________________________|");
                Selection1 = Convert.ToInt32(Console.ReadLine());

                if (Selection1 == 1)
                {
                    ////secondary menu for the main order category
                    Console.WriteLine("                                               ___________________________________________________________________________________");
                    Console.WriteLine("                                              |                                                                                   |");
                    Console.WriteLine("                                              |    Please enter the number indicating which category you want to order from       |");
                    Console.WriteLine("                                              |                                                                                   |");
                    Console.WriteLine("                                              |                                                                                   |");
                    Console.WriteLine("                                              |                             1 -     Breakfast                                     |");
                    Console.WriteLine("                                              |                                                                                   |");
                    Console.WriteLine("                                              |                             2 -     Sandwiches                                    |");
                    Console.WriteLine("                                              |___________________________________________________________________________________|");
                    Selection2 = Convert.ToInt32(Console.ReadLine());
                    if (Selection2 == 1)
                    {
                        ////item selection
                        Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                          1 - Chicken McMuuffin (" + cals1[1] + " Cals) - $" + price1[1] + "                      9 - Plain Bagel with Regular Cream Cheese Product (" + cals1[9] + " cals) - $" + price1[9]);
                        Console.WriteLine("                          2 - Egg McMuffin (" + cals1[2] + " cals) - $" + price1[2] + "                          10 - Everything Bagel with Regular Cream Chese Product (" + cals1[10] + " cals) - $" + price1[10]);
                        Console.WriteLine("                          3 - Sausage 'N Egg McMuffin (" + cals1[3] + " cals) - $" + price1[3] + "               11 - Sesame Bagel with Regular Cream Chese Product (" + cals1[11] + " cals) - $" + price1[11]);
                        Console.WriteLine("                          4 - Bacon 'N Egg McMuffin (" + cals1[4] + " cals) - $" + price1[4] + "                 12 - Egg BLT Bagel with Plain Bagel (" + cals1[12] + " cals) - $" + price1[12]);
                        Console.WriteLine("                          5 - Sausage McMuffin (" + cals1[5] + " cals) - $" + price1[5] + "                      13 - Egg BLT Bagel with Everything Bagel (" + cals1[13] + " cals) - $" + price1[13]);
                        Console.WriteLine("                          6 - Plain Bagel with Butter (" + cals1[6] + " cals) - $" + price1[6] + "               14 - Sesame Egg BLT Bagel (" + cals1[14] + " cals) - $" + price1[14]);
                        Console.WriteLine("                          7 - Everything Bagel with Butter (" + cals1[7] + " cals) - $" + price1[7] + "          15 - Bacon N' Egg Bagel with Plain Bagel (" + cals1[15] + " cals) - $" + price1[15]);
                        Console.WriteLine("                          8 - Sesame Bagel with Butter (" + cals1[8] + " cals) - $" + price1[8] + "              16 - Bacon N' Egg Bagel with Everything Bagel (" + cals1[16] + " cals) - $" + price1[16]);
                        Console.WriteLine();
                        Console.WriteLine("                                                           17 - Sesame Bacon N' Egg Bagel (" + cals1[17] + " cals) - $" + price1[17]);
                        Console.WriteLine("                                                           18 - Sausage N' Egg Bagel with Plain Bagel (" + cals1[18] + " cals) - $" + price1[18]);
                        Console.WriteLine("                                                           19 - Sausage N' Egg Bagel with Everything Bagel (" + cals1[19] + " cals) - $" + price1[19]);
                        Console.WriteLine("                                                           20 - Sesame Sausage N' Egg Bagel (" + cals1[20] + " cals) - $" + price1[20]);
                        Console.WriteLine("                                                           21 - Bacon N' Egg Bagel with Everything Bagel (" + cals1[21] + " cals) - $" + price1[21]);
                        Console.WriteLine("                                                           22 - Breakfast Burrito (" + cals1[22] + " cals) - $" + price1[22]);
                        Console.WriteLine("                                                           23 - Hash Browns (" + cals1[23] + " cals) - $" + price1[23]);
                        Console.WriteLine("                                                           24 - Hotcakes with Syrup and Butter (" + cals1[24] + " cals) - $" + price1[24]);
                        Selection3 = Convert.ToInt32(Console.ReadLine());

                        ////this gives customer opportunity to order again from this category or go back to main menu
                        Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                        Selection4 = Convert.ToString(Console.ReadLine());
                        if (Selection4 == "yes")
                        {
                            Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("                          1 - Chicken McMuuffin (" + cals1[1] + " Cals) - $" + price1[1] + "                      9 - Plain Bagel with Regular Cream Cheese Product (" + cals1[9] + " cals) - $" + price1[9]);
                            Console.WriteLine("                          2 - Egg McMuffin (" + cals1[2] + " cals) - $" + price1[2] + "                          10 - Everything Bagel with Regular Cream Chese Product (" + cals1[10] + " cals) - $" + price1[10]);
                            Console.WriteLine("                          3 - Sausage 'N Egg McMuffin (" + cals1[3] + " cals) - $" + price1[3] + "               11 - Sesame Bagel with Regular Cream Chese Product (" + cals1[11] + " cals) - $" + price1[11]);
                            Console.WriteLine("                          4 - Bacon 'N Egg McMuffin (" + cals1[4] + " cals) - $" + price1[4] + "                 12 - Egg BLT Bagel with Plain Bagel (" + cals1[12] + " cals) - $" + price1[12]);
                            Console.WriteLine("                          5 - Sausage McMuffin (" + cals1[5] + " cals) - $" + price1[5] + "                      13 - Egg BLT Bagel with Everything Bagel (" + cals1[13] + " cals) - $" + price1[13]);
                            Console.WriteLine("                          6 - Plain Bagel with Butter (" + cals1[6] + " cals) - $" + price1[6] + "               14 - Sesame Egg BLT Bagel (" + cals1[14] + " cals) - $" + price1[14]);
                            Console.WriteLine("                          7 - Everything Bagel with Butter (" + cals1[7] + " cals) - $" + price1[7] + "          15 - Bacon N' Egg Bagel with Plain Bagel (" + cals1[15] + " cals) - $" + price1[15]);
                            Console.WriteLine("                          8 - Sesame Bagel with Butter (" + cals1[8] + " cals) - $" + price1[8] + "              16 - Bacon N' Egg Bagel with Everything Bagel (" + cals1[16] + " cals) - $" + price1[16]);
                            Console.WriteLine();
                            Console.WriteLine("                                                           17 - Sesame Bacon N' Egg Bagel (" + cals1[17] + " cals) - $" + price1[17]);
                            Console.WriteLine("                                                           18 - Sausage N' Egg Bagel with Plain Bagel (" + cals1[18] + " cals) - $" + price1[18]);
                            Console.WriteLine("                                                           19 - Sausage N' Egg Bagel with Everything Bagel (" + cals1[19] + " cals) - $" + price1[19]);
                            Console.WriteLine("                                                           20 - Sesame Sausage N' Egg Bagel (" + cals1[20] + " cals) - $" + price1[20]);
                            Console.WriteLine("                                                           21 - Bacon N' Egg Bagel with Everything Bagel (" + cals1[21] + " cals) - $" + price1[21]);
                            Console.WriteLine("                                                           22 - Breakfast Burrito (" + cals1[22] + " cals) - $" + price1[22]);
                            Console.WriteLine("                                                           23 - Hash Browns (" + cals1[23] + " cals) - $" + price1[23]);
                            Console.WriteLine("                                                           24 - Hotcakes with Syrup and Butter (" + cals1[24] + " cals) - $" + price1[24]);
                            Selection5 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                            Selection4 = Convert.ToString(Console.ReadLine());
                        }
                        if (Selection4 == "no")
                        {
                            continue;

                        }
                    }





                    if (Selection2 == 2)
                    {

                        ////item selection
                        Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                                                                 1 - Big Mac (" + cals2[1] + " cals) - $" + price2[1]);
                        Console.WriteLine("                                                                 2 - Double Big Mac (" + cals2[2] + " cals) - $" + price2[2]);
                        Console.WriteLine("                                                                 3 - Quarter Pounder with Cheese (" + cals2[3] + " cals) - $" + price2[3]);
                        Console.WriteLine("                                                                 4 - Quarter Pounder BLT (" + cals2[4] + " cals) - $" + price2[4]);
                        Console.WriteLine("                                                                 5 - Quarter Pounder without Cheese (" + cals2[5] + " cals) - $" + price2[5]);
                        Console.WriteLine("                                                                 6 - Double Quarter Pounder BLT (" + cals2[6] + " cals) - $" + price2[6]);
                        Console.WriteLine("                                                                 7 - Double Quarter Pounder with Cheese (" + cals2[7] + " cals) - $" + price2[7]);
                        Console.WriteLine("                                                                 8 - Double Cheese Burger (" + cals2[8] + " cals) - $" + price2[8]);
                        Console.WriteLine("                                                                 9 - Double Hamburger (" + cals2[9] + " cals) - $" + price2[9]);
                        Console.WriteLine("                                                                10 - Filet-O-Fish (" + cals2[10] + " cals) - $" + price2[10]);
                        Console.WriteLine("                                                                11 - Double Filet-O-Fish (" + cals2[11] + " cals) - $" + price2[11]);
                        Selection6 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                        Selection7 = Convert.ToString(Console.ReadLine());
                        if (Selection7 == "yes")
                        {
                            Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("                                                                 1 - Big Mac (" + cals2[1] + " cals) - $" + price2[1]);
                            Console.WriteLine("                                                                 2 - Double Big Mac (" + cals2[2] + " cals) - $" + price2[2]);
                            Console.WriteLine("                                                                 3 - Quarter Pounder with Cheese (" + cals2[3] + " cals) - $" + price2[3]);
                            Console.WriteLine("                                                                 4 - Quarter Pounder BLT (" + cals2[4] + " cals) - $" + price2[4]);
                            Console.WriteLine("                                                                 5 - Quarter Pounder without Cheese (" + cals2[5] + " cals) - $" + price2[5]);
                            Console.WriteLine("                                                                 6 - Double Quarter Pounder BLT (" + cals2[6] + " cals) - $" + price2[6]);
                            Console.WriteLine("                                                                 7 - Double Quarter Pounder with Cheese (" + cals2[7] + " cals) - $" + price2[7]);
                            Console.WriteLine("                                                                 8 - Double Cheese Burger (" + cals2[8] + " cals) - $" + price2[8]);
                            Console.WriteLine("                                                                 9 - Double Hamburger (" + cals2[9] + " cals) - $" + price2[9]);
                            Console.WriteLine("                                                                10 - Filet-O-Fish (" + cals2[10] + " cals) - $" + price2[10]);
                            Console.WriteLine("                                                                11 - Double Filet-O-Fish (" + cals2[11] + " cals) - $" + price2[11]);
                            Selection8 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                            Selection7 = Convert.ToString(Console.ReadLine());
                        }
                        if (Selection7 == "no")
                        {
                            continue;
                        }
                    }
                }





                if (Selection1 == 2)
                {


                    Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                                               1 - Brownie Cookie (" + cals3[1] + " cals) - $" + price3[1]);
                    Console.WriteLine("                                                               2 - Apple Slices (" + cals3[2] + " cals) - $" + price3[2]);
                    Console.WriteLine("                                                               3 - Chocolate Chunk Cookie (" + cals3[3] + " cals) - $" + price3[3]);
                    Console.WriteLine("                                                               4 - World Famous Fries (" + cals3[4] + " cals) - $" + price3[4]);
                    Console.WriteLine("                                                               5 - Mini Fry (" + cals3[5] + " cals) - $" + price3[5]);
                    Console.WriteLine("                                                               6 - Poutine (" + cals3[6] + " cals) - $" + price3[6]);
                    Console.WriteLine("                                                               7 - Carrots (" + cals3[7] + " cals) - $" + price3[7]);
                    Console.WriteLine("                                                               8 - Fruit and Fibre Muffin (" + cals3[8] + " cals) - $" + price3[8]);
                    Console.WriteLine("                                                               9 - Blueberry Muffin (" + cals3[9] + " cals) - $" + price3[9]);
                    Console.WriteLine("                                                              10 - Carrot Muffin (" + cals3[10] + " cals) - $" + price3[10]);
                    Console.WriteLine("                                                              11 - Cranberry Orange Muffin (" + cals3[11] + " cals) - $" + price3[11]);
                    Console.WriteLine("                                                              12 - Banana Chocolate Chunk Muffin (" + cals3[12] + " cals) - $" + price3[12]);
                    Selection9 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                    Selection10 = Convert.ToString(Console.ReadLine());

                    if (Selection10 == "yes")
                    {
                        Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                                                               1 - Brownie Cookie (" + cals3[1] + " cals) - $" + price3[1]);
                        Console.WriteLine("                                                               2 - Apple Slices (" + cals3[2] + " cals) - $" + price3[2]);
                        Console.WriteLine("                                                               3 - Chocolate Chunk Cookie (" + cals3[3] + " cals) - $" + price3[3]);
                        Console.WriteLine("                                                               4 - World Famous Fries (" + cals3[4] + " cals) - $" + price3[4]);
                        Console.WriteLine("                                                               5 - Mini Fry (" + cals3[5] + " cals) - $" + price3[5]);
                        Console.WriteLine("                                                               6 - Poutine (" + cals3[6] + " cals) - $" + price3[6]);
                        Console.WriteLine("                                                               7 - Carrots (" + cals3[7] + " cals) - $" + price3[7]);
                        Console.WriteLine("                                                               8 - Fruit and Fibre Muffin (" + cals3[8] + " cals) - $" + price3[8]);
                        Console.WriteLine("                                                               9 - Blueberry Muffin (" + cals3[9] + " cals) - $" + price3[9]);
                        Console.WriteLine("                                                              10 - Carrot Muffin (" + cals3[10] + " cals) - $" + price3[10]);
                        Console.WriteLine("                                                              11 - Cranberry Orange Muffin (" + cals3[11] + " cals) - $" + price3[11]);
                        Console.WriteLine("                                                              12 - Banana Chocolate Chunk Muffin (" + cals3[12] + " cals) - $" + price3[12]);
                        Selection11 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                        Selection10 = Convert.ToString(Console.ReadLine());
                    }
                    if (Selection10 == "no")
                    {
                        continue;
                    }


                }


                if (Selection1 == 3)
                {

                    Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                                              1 - Hot Fudge Sundae (" + cals4[1] + " cals) - $" + price4[1]);
                    Console.WriteLine("                                                              2 - Hot Caramel Sundae (" + cals4[2] + " cals) - $" + price4[2]);
                    Console.WriteLine("                                                              3 - Slam Dunk Cookie McFlurry (" + cals4[3] + " cals) - $" + price4[3]);
                    Console.WriteLine("                                                              4 - Oreo McFlurry (" + cals4[4] + " cals) - $" + price4[4]);
                    Console.WriteLine("                                                              5 - SKOR McFlurry (" + cals4[5] + " cals) - $" + price4[5]);
                    Console.WriteLine("                                                              6 - Smarties McFlurry (" + cals4[6] + " cals) - $" + price4[6]);
                    Console.WriteLine("                                                              7 - Vanila Cone (" + cals4[7] + " cals) - $" + price4[7]);
                    Console.WriteLine("                                                              8 - Chocolate Triple Thick Milkshake (" + cals4[8] + " cals) - $" + price4[8]);
                    Console.WriteLine("                                                              9 - Vanila Triple Thick Milkshake (" + cals4[9] + " cals) - $" + price4[9]);
                    Console.WriteLine("                                                             10 - Strawberry Triple Thick Milkshake (" + cals4[10] + " cals) - $" + price4[10]);
                    Console.WriteLine("                                                             11 - Chocolate Chip Cookie Milkshake (" + cals4[11] + " cals) - $" + price4[11]);
                    Console.WriteLine("                                                             12 - Strawberry Yogurt Tube (" + cals4[12] + " cals) - $" + price4[12]);
                    Console.WriteLine("                                                             13 - Baked Apple Pie (" + cals4[13] + " cals) - $" + price4[13]);
                    Selection12 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                    Selection13 = Convert.ToString(Console.ReadLine());

                    if (Selection13 == "yes")
                    {
                        Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                                                              1 - Hot Fudge Sundae (" + cals4[1] + " cals) - $" + price4[1]);
                        Console.WriteLine("                                                              2 - Hot Caramel Sundae (" + cals4[2] + " cals) - $" + price4[2]);
                        Console.WriteLine("                                                              3 - Slam Dunk Cookie McFlurry (" + cals4[3] + " cals) - $" + price4[3]);
                        Console.WriteLine("                                                              4 - Oreo McFlurry (" + cals4[4] + " cals) - $" + price4[4]);
                        Console.WriteLine("                                                              5 - SKOR McFlurry (" + cals4[5] + " cals) - $" + price4[5]);
                        Console.WriteLine("                                                              6 - Smarties McFlurry (" + cals4[6] + " cals) - $" + price4[6]);
                        Console.WriteLine("                                                              7 - Vanila Cone (" + cals4[7] + " cals) - $" + price4[7]);
                        Console.WriteLine("                                                              8 - Chocolate Triple Thick Milkshake (" + cals4[8] + " cals) - $" + price4[8]);
                        Console.WriteLine("                                                              9 - Vanila Triple Thick Milkshake (" + cals4[9] + " cals) - $" + price4[9]);
                        Console.WriteLine("                                                             10 - Strawberry Triple Thick Milkshake (" + cals4[10] + " cals) - $" + price4[10]);
                        Console.WriteLine("                                                             11 - Chocolate Chip Cookie Milkshake (" + cals4[11] + " cals) - $" + price4[11]);
                        Console.WriteLine("                                                             12 - Strawberry Yogurt Tube (" + cals4[12] + " cals) - $" + price4[12]);
                        Console.WriteLine("                                                             13 - Baked Apple Pie (" + cals4[13] + " cals) - $" + price4[13]);
                        Selection14 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                        Selection13 = Convert.ToString(Console.ReadLine());
                    }
                    if (Selection13 == "no")
                    {
                        continue;
                    }
                }


                if (Selection1 == 4)
                {
                    Console.WriteLine("                                               __________________________________________________________________________________");
                    Console.WriteLine("                                              |                                                                                  |");
                    Console.WriteLine("                                              |    Please enter the number indicating which category you want to order from      |");
                    Console.WriteLine("                                              |                                                                                  |");
                    Console.WriteLine("                                              |                                                                                  |");
                    Console.WriteLine("                                              |                            1 - Hot Beverages                                     |");
                    Console.WriteLine("                                              |                                                                                  |");
                    Console.WriteLine("                                              |                            2 - Cold Beverages                                    |");
                    Console.WriteLine("                                              |__________________________________________________________________________________|");
                    Selection15 = Convert.ToInt32(Console.ReadLine());


                    if (Selection15 == 1)
                    {

                        Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                              1 - Premium Roast Brewed Coffee (" + cals5[1] + " cals) - $" + price5[1] + "               9 - French Vanila Latte - 2% Milk (" + cals5[9] + " cals) - $" + price5[9]);
                        Console.WriteLine("                              2 - Premium Roast Decaf Coffee (" + cals5[2] + " cals) - $" + price5[2] + "               10 - Caramel Latte - 2% Milk (" + cals5[10] + " cals) - $" + price5[10]);
                        Console.WriteLine("                              3 - Cappuccino - 2% milk (" + cals5[3] + " cals) - $" + price5[3] + "                   11 - Mocha - 2% Milk (" + cals5[11] + " cals) - $" + price5[11]);
                        Console.WriteLine("                              4 - French Vanila Cappuccino - 2% Milk (" + cals5[4] + " cals) - $" + price5[4] + "     12 - Peppermint Mocha (" + cals5[12] + " cals) - $" + price5[12]);
                        Console.WriteLine("                              5 - Caramel Cappuccino - 2% Milk (" + cals5[5] + " cals) - $" + price5[5] + "           13 - Espresso (" + cals5[13] + " cals) - $" + price5[13]);
                        Console.WriteLine("                              6 - Premium Tea (" + cals5[6] + " cals) - $" + price5[6] + "                              14 - Double Espresso (" + cals5[14] + " cals) - $" + price5[14]);
                        Console.WriteLine("                              7 - Latte - 2% Milk (" + cals5[7] + " cals) - $" + price5[7] + "                        15 - Americano (" + cals5[15] + " cals) - $" + price5[15]);
                        Console.WriteLine("                              8 - Pumpkin Spice Latte (" + cals5[8] + " cals) - $" + price5[8] + "                    16 - Hot Chocolate - 2% Milk (" + cals5[16] + " cals) - $" + price5[16]);
                        Console.WriteLine();
                        Console.WriteLine("                           *All prices and calories listed above are for the medium sized product. You will be asked below for your size preference.");
                        Selection16 = Convert.ToInt32(Console.ReadLine());

                        while (true)
                        {
                            Console.WriteLine("                                                        Would you like this item in Small, Medium, or Large? Answer with 's', 'm', or 'l'.");
                            string Selection33 = Convert.ToString(Console.ReadLine());


                            if (Selection33 == "s")
                            {
                                Selection26 = price5[Selection16] - 0.60;
                                Selectioncals1 = cals5[Selection16] - (cals5[Selection16] * 0.30);
                                Selectioncals1 = Math.Round(Selectioncals1, 0);
                                Console.WriteLine("                         There are " + Selectioncals1 + " cals and the price is $" + Selection26 + ". Do you want to confirm or choose a different size? Answer with 'confirm' or 'different'. ");
                                string Selection31 = Convert.ToString(Console.ReadLine());
                                if (Selection31 == "confirm")
                                {
                                    break;
                                }
                                else
                                {
                                    continue;
                                }

                            }

                            if (Selection33 == "m")
                            {
                                Selection26 = price5[Selection16];
                                Selectioncals1 = cals5[Selection16];
                                Selectioncals1 = Math.Round(Selectioncals1, 0);
                                Console.WriteLine("                         There are " + Selectioncals1 + " cals and the price is $" + Selection26 + ". Do you want to confirm or choose a different size? Answer with 'confirm' or 'different'. ");
                                string Selection31 = Convert.ToString(Console.ReadLine());
                                if (Selection31 == "confirm")
                                {
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }

                            if (Selection33 == "l")
                            {
                                Selection26 = price5[Selection16] + 0.60;
                                Selectioncals1 = cals5[Selection16] + (cals5[Selection16] * 0.30);
                                Selectioncals1 = Math.Round(Selectioncals1, 0);
                                Console.WriteLine("                         There are " + Selectioncals1 + " cals and the price is $" + Selection26 + ". Do you want to confirm or choose a different size? Answer with 'confirm' or 'different'. ");
                                string Selection31 = Convert.ToString(Console.ReadLine());
                                if (Selection31 == "confirm")
                                {
                                    break;
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }

                        Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                        Selection17 = Convert.ToString(Console.ReadLine());

                        if (Selection17 == "yes")
                        {
                            Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("                              1 - Premium Roast Brewed Coffee (" + cals5[1] + " Cals) - $" + price5[1] + "               9 - French Vanila Latte - 2% Milk (" + cals5[9] + " cals) - $" + price5[9]);
                            Console.WriteLine("                              2 - Premium Roast Decaf Coffee (" + cals5[2] + " cals) - $" + price5[2] + "               10 - Caramel Latte - 2% Milk (" + cals5[10] + " cals) - $" + price5[10]);
                            Console.WriteLine("                              3 - Cappuccino - 2% milk (" + cals5[3] + " cals) - $" + price5[3] + "                   11 - Mocha - 2% Milk (" + cals5[11] + " cals) - $" + price5[11]);
                            Console.WriteLine("                              4 - French Vanila Cappuccino - 2% Milk (" + cals5[4] + " cals) - $" + price5[4] + "     12 - Peppermint Mocha (" + cals5[12] + " cals) - $" + price5[12]);
                            Console.WriteLine("                              5 - Caramel Cappuccino - 2% Milk (" + cals5[5] + " cals) - $" + price5[5] + "           13 - Espresso (" + cals5[13] + " cals) - $" + price5[13]);
                            Console.WriteLine("                              6 - Premium Tea (" + cals5[6] + " cals) - $" + price5[6] + "                              14 - Double Espresso (" + cals5[14] + " cals) - $" + price5[14]);
                            Console.WriteLine("                              7 - Latte - 2% Milk (" + cals5[7] + " cals) - $" + price5[7] + "                        15 - Americano (" + cals5[15] + " cals) - $" + price5[15]);
                            Console.WriteLine("                              8 - Pumpkin Spice Latte (" + cals5[8] + " cals) - $" + price5[8] + "                    16 - Hot Chocolate - 2% Milk (" + cals5[16] + " cals) - $" + price5[16]);
                            Console.WriteLine();
                            Console.WriteLine("                           *All prices and calories listed above are for the medium sized product. You will be asked below for your size preference.");
                            Selection18 = Convert.ToInt32(Console.ReadLine());


                            ////This is where I add an option for sizes
                            while (true)
                            {
                                Console.WriteLine(" Would you like this item in Small, Medium, or Large? Answer with 's', 'm', or 'l'.");
                                Console.WriteLine();

                                string Selection27 = Convert.ToString(Console.ReadLine());

                                if (Selection27 == "s")
                                {
                                    Selection28 = price5[Selection18] - 0.60;
                                    Selectioncals2 = cals5[Selection18] - (cals5[Selection18] * 0.30);
                                    Selectioncals2 = Math.Round(Selectioncals2, 0);
                                    Console.WriteLine("                         There are " + Selectioncals2 + " cals and the price is $" + Selection28 + ". Do you want to confirm or choose a different size? Answer with 'confirm' or 'different'. ");
                                    string Selection30 = Convert.ToString(Console.ReadLine());
                                    if (Selection30 == "confirm")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }

                                }

                                if (Selection27 == "m")
                                {
                                    Selection28 = price5[Selection18];
                                    Selectioncals2 = cals5[Selection18];
                                    Selectioncals2 = Math.Round(Selectioncals2, 0);
                                    Console.WriteLine("                         There are " + Selectioncals2 + " cals and the price is $" + Selection28 + ". Do you want to confirm or choose a different size? Answer with 'confirm' or 'different'. ");
                                    string Selection30 = Convert.ToString(Console.ReadLine());
                                    if (Selection30 == "confirm")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }

                                if (Selection27 == "l")
                                {
                                    Selection28 = price5[Selection18] + 0.60;
                                    Selectioncals2 = cals5[Selection18] + (cals5[Selection18] * 0.30);
                                    Selectioncals2 = Math.Round(Selectioncals2, 0);
                                    Console.WriteLine("                         There are " + Selectioncals2 + " cals and the price is $" + Selection28 + ". Do you want to confirm or choose a different size? Answer with 'confirm' or 'different'. ");
                                    string Selection30 = Convert.ToString(Console.ReadLine());
                                    if (Selection30 == "confirm")
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                }
                            }
                            Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                            Selection17 = Convert.ToString(Console.ReadLine());
                        }
                        if (Selection17 == "no")
                        {
                            continue;
                        }



                    }
                    if (Selection15 == 2)
                    {

                        Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("          1 - Dasani Water (" + cals6[1] + " Cals) - $" + price6[1] + "                                              9 - Bluberry Pomegranate Real Fruit Smoothie without Yogurt (" + cals6[9] + " cals) - $" + price6[9]);
                        Console.WriteLine("          2 - Fountain Drink (" + cals6[2] + " cals) - $" + price6[2] + "                                          10 - Mango Pineapple Real Fruit Smoothie with Yogurt (" + cals6[10] + " cals) - $" + price6[10]);
                        Console.WriteLine("          3 - Premium Roast Brewed Iced Coffee (" + cals6[3] + " cals) - $" + price6[3] + "                        11 - Mango Pineapple Real Fruit Smoothie without Yogurt (" + cals6[11] + " cals) - $" + price6[11]);
                        Console.WriteLine("          4 - French Vanila Iced Coffee (" + cals6[4] + " cals) - $" + price6[4] + "                               12 - McCafe Coffee Iced Frappe (" + cals6[12] + " cals) - $" + price6[12]);
                        Console.WriteLine("          5 - Caramel Iced Coffee (" + cals6[5] + " cals) - $" + price6[5] + "                                     13 - Minute Maid Orange Juice (" + cals6[13] + " cals) - $" + price6[13]);
                        Console.WriteLine("          6 - Strawberry & Banana Real Fruit Smoothie with Yogurt (" + cals6[6] + " cals) - $" + price6[6] + "     14 - Minute Maid Apple Juice (" + cals6[14] + " cals) - $" + price6[14]);
                        Console.WriteLine("          7 - Strawberry & Banana Real Fruit Smoothie without Yogurt (" + cals6[7] + " cals) - $" + price6[7] + "  15 - 1% Partly Skimmed Milk - 250 ml (" + cals6[15] + " cals) - $" + price6[15]);
                        Console.WriteLine("          8 - Bluberry Pomegranate Real Fruit Smoothie with Yogurt (" + cals6[8] + " cals) - $" + price6[8] + "    16 - 1% Partly Skimmed Chocolate Milk - 250 ml (" + cals6[16] + " cals) - $" + price6[16]);

                        Selection19 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                        Selection20 = Convert.ToString(Console.ReadLine());

                        if (Selection20 == "yes")
                        {

                            Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("          1 - Dasani Water (" + cals6[1] + " Cals) - $" + price6[1] + "                                              9 - Bluberry Pomegranate Real Fruit Smoothie without Yogurt (" + cals6[9] + " cals) - $" + price6[9]);
                            Console.WriteLine("          2 - Fountain Drink (" + cals6[2] + " cals) - $" + price6[2] + "                                          10 - Mango Pineapple Real Fruit Smoothie with Yogurt (" + cals6[10] + " cals) - $" + price6[10]);
                            Console.WriteLine("          3 - Premium Roast Brewed Iced Coffee (" + cals6[3] + " cals) - $" + price6[3] + "                        11 - Mango Pineapple Real Fruit Smoothie without Yogurt (" + cals6[11] + " cals) - $" + price6[11]);
                            Console.WriteLine("          4 - French Vanila Iced Coffee (" + cals6[4] + " cals) - $" + price6[4] + "                               12 - McCafe Coffee Iced Frappe (" + cals6[12] + " cals) - $" + price6[12]);
                            Console.WriteLine("          5 - Caramel Iced Coffee (" + cals6[5] + " cals) - $" + price6[5] + "                                     13 - Minute Maid Orange Juice (" + cals6[13] + " cals) - $" + price6[13]);
                            Console.WriteLine("          6 - Strawberry & Banana Real Fruit Smoothie with Yogurt (" + cals6[6] + " cals) - $" + price6[6] + "     14 - Minute Maid Apple Juice (" + cals6[14] + " cals) - $" + price6[14]);
                            Console.WriteLine("          7 - Strawberry & Banana Real Fruit Smoothie without Yogurt (" + cals6[7] + " cals) - $" + price6[7] + "  15 - 1% Partly Skimmed Milk - 250 ml (" + cals6[15] + " cals) - $" + price6[15]);
                            Console.WriteLine("          8 - Bluberry Pomegranate Real Fruit Smoothie with Yogurt (" + cals6[8] + " cals) - $" + price6[8] + "    16 - 1% Partly Skimmed Chocolate Milk - 250 ml (" + cals6[16] + " cals) - $" + price6[16]);
                            Selection21 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                            Selection20 = Convert.ToString(Console.ReadLine());
                        }
                        if (Selection20 == "no")
                        {
                            continue;
                        }
                    }

                }




                if (Selection1 == 5)
                {



                    Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                                         1 - 4 Chicken McNuggets Happy Meal (" + cals7[1] + " Cals) - $" + price7[1]);
                    Console.WriteLine("                                                         2 - Snack Wrap with Crispy Chicken Happy Meal (" + cals7[2] + " cals) - $" + price7[2]);
                    Console.WriteLine("                                                         3 - Snack Wrap with Grilled Chicken Happy Meal (" + cals7[3] + " cals) - $" + price7[3]);
                    Console.WriteLine("                                                         4 - Cheeseburger Happy Meal (" + cals7[4] + " cals) - $" + price7[4]);
                    Console.WriteLine("                                                         5 - Hamburger Happy Meal (" + cals7[5] + " cals) - $" + price7[5]);
                    Console.WriteLine("                                                         6 - Hotcakes Happy Meal (" + cals7[6] + " cals) - $" + price7[6]);
                    Selection22 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                    Selection23 = Convert.ToString(Console.ReadLine());

                    if (Selection23 == "yes")
                    {
                        Console.WriteLine("                                    Please select the item(s) of your choice by typing in the number written beside the product of your choice ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                                                         1 - 4 Chicken McNuggets Happy Meal (" + cals7[1] + " Cals) - $" + price7[1]);
                        Console.WriteLine("                                                         2 - Snack Wrap with Crispy Chicken Happy Meal (" + cals7[2] + " cals) - $" + price7[2]);
                        Console.WriteLine("                                                         3 - Snack Wrap with Grilled Chicken Happy Meal (" + cals7[3] + " cals) - $" + price7[3]);
                        Console.WriteLine("                                                         4 - Cheeseburger Happy Meal (" + cals7[4] + " cals) - $" + price7[4]);
                        Console.WriteLine("                                                         5 - Hamburger Happy Meal (" + cals7[5] + " cals) - $" + price7[5]);
                        Console.WriteLine("                                                         6 - Hotcakes Happy Meal (" + cals7[6] + " cals) - $" + price7[6]);
                        Selection24 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(" Would you like to order something else from this category? Type 'yes' to continue ordering in this category, or type 'no' to go to a different category or finalize your order.");
                        Selection23 = Convert.ToString(Console.ReadLine());
                    }
                    if (Selection23 == "no")
                    {
                        continue;
                    }

                }
                if (Selection1 == 6)
                {
                    ////payment section, where customer will receive total calories, along with the total price for all items selected
                    double subtotal = price1[Selection3] + price1[Selection5] + price2[Selection6] + price2[Selection8] + price3[Selection9] + price3[Selection11] + price4[Selection12] + price4[Selection14] + Selection26 + Selection28 + price6[Selection19] + price6[Selection21] + price7[Selection22] + price7[Selection24];
                    double caloriecount = cals1[Selection3] + cals1[Selection5] + cals2[Selection6] + cals2[Selection8] + cals3[Selection9] + cals3[Selection11] + cals4[Selection12] + cals4[Selection14] + Selectioncals1 + Selectioncals2 + cals6[Selection19] + cals6[Selection21] + cals7[Selection22] + cals7[Selection24];
                    Console.WriteLine("                                                    __________________________________________________________________________________");
                    Console.WriteLine("                                                   |                                                                                  |");
                    Console.WriteLine("                                                   |               Your total calorie count is " + caloriecount + " cals.             |");
                    Console.WriteLine("                                                   |                                                                                  |");
                    Console.WriteLine("                                                   |                         Your subtotal is $" + subtotal + ".                      |");
                    Console.WriteLine("                                                   |                                                                                  |");

                    double total = (subtotal * 0.13) + subtotal;
                    total = Math.Round(total, 2);
                    Console.WriteLine("                                                   |                                                                                  |");
                    ////payment methods, where customer will select how they would like to pay
                    Console.WriteLine("                                                   |          With tax, your total is $" + total + ". How would you like to pay?      |");
                    Console.WriteLine("                                                   |                                                                                  |");
                    Console.WriteLine("                                                   |                                                                                  |");
                    Console.WriteLine("                                                   |     1 - Visa / Debit                                    2 - Cash                 |");
                    Console.WriteLine("                                                   |                                                                                  |");
                    Console.WriteLine("                                                   |                                                                                  |");
                    Console.WriteLine("                                                   |       Enter a number from 1-2 to select your choice of payment                   | ");
                    Console.WriteLine("                                                   |__________________________________________________________________________________|");
                    PaymentMethod = Convert.ToDouble(Console.ReadLine());

                    if (PaymentMethod == 2)
                    {
                        ////this is just cash, if you are going to the store to pick up your order and want to pay cash
                        Console.WriteLine("                                                                           Have a great day. ");

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.ReadLine();
                        break;

                    }

                    if (PaymentMethod == 1)
                    {
                        ////credit card payment
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("                                                                   Type 't' for tap or 'i' for insert.");
                        VisaPaymentMethod = Convert.ToString(Console.ReadLine());
                        if (VisaPaymentMethod == "t")
                        {
                            ////tap
                            Console.WriteLine("                                                                    Please tap your card on the screen");
                            Console.WriteLine();
                            Console.WriteLine();
                            Thread.Sleep(miliseconds);
                            Console.WriteLine("                                                                    Payment Complete! Have a great day. ");
                            Console.WriteLine();
                            Console.WriteLine();

                            Console.ReadLine();
                            break;
                        }


                    }

                    if (VisaPaymentMethod == "i")
                    {
                        ////insert, where you enter your 4 digit code to complete the payment
                        while (true)
                        {

                            Console.WriteLine();
                            Console.WriteLine("                                                          Enter your 4 digit code to complete your payment ");
                            codeentered = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine("                                                                           Please wait...");
                            Thread.Sleep(miliseconds);
                            Console.WriteLine();
                            if (codeentered == code)
                            {
                                Console.WriteLine("                                                  Payment Completed, we hope you enjoy your order. Have a great day!");
                                break;

                            }


                            if (codeentered != code)
                            {
                                ////if you enter the 4 digit code wrong, you have to try again
                                Console.WriteLine();
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Clear();

                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("                                                        Payment Cancelled, Please Re-Enter your 4-digit code");
                                Console.ReadLine();
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.Clear();
                                continue;
                            }
                        }
                        Console.ReadLine();
                        break;


                    }
                }


                if (Selection1 == 7)
                {
                    ////this is if you don't want to buy anything, you can just exit the program
                    Console.WriteLine("                                                                        Thankyou, have a great day.");
                    Thread.Sleep(miliseconds);
                    break;
                }
                if (Selection1 > 7)
                {
                    ////this will give an error message, as there is no category above the number 7, so you will have to try again
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("                                                                   Invalid entry. Press enter to try again.");
                    Console.ReadLine();
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Clear();
                }
            }

        }
    }
}
