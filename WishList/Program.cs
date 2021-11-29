﻿using System;
using System.Collections.Generic;

namespace WishList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> myWishList = new List<string>();

            Console.WriteLine(myWishList.Count);

            myWishList.Add("coffee machine");
            myWishList.Add("new pair of socks");
            myWishList.Add("box of chocolate");
            myWishList.Add("new pillow");

            Console.WriteLine(myWishList.Count);

            Console.WriteLine(myWishList[0]);
            Console.WriteLine(myWishList[1]);
            Console.WriteLine(myWishList[2]);

            Console.WriteLine(myWishList.Count);

            foreach(string wish in myWishList)
            {
                Console.WriteLine(wish);
            }
        }
    }
}
