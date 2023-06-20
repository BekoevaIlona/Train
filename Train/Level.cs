﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train
{

    class Level
    {
        public static int level = 0;
        public static int[] level_lst = { 8, 12, 19 };
        public List<int> IndexesCards;
        public List<int> IndexesWagons;
        static Random rnd = new Random();
        public Level(int lev)
        {
            level = lev;
            HashSet<int> set = new HashSet<int>();
            while (lev < 3 && set.Count != level_lst[level])
            {
                set.Add(rnd.Next(0, 19));
            }
            IndexesWagons = set.ToList();
            IndexesCards = new List<int>(IndexesWagons);

            int n = IndexesCards.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                int value = IndexesCards[k];
                IndexesCards[k] = IndexesCards[n];
                IndexesCards[n] = value;
            }
        }


    }
}
