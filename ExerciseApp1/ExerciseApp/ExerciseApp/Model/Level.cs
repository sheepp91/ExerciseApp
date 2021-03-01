using System;
using System.Collections.Generic;
using System.Text;
using ExerciseApp.View;

namespace ExerciseApp.Model
{
    public class Level
    {
        //current level
        public int level = 1;

        //current runningTime
        public double runningTime = 13.0;

        //next level timeRequirement, this needs to be adjusted based on the exact level
        public double nextLevel = 12.5;

        //modifier for required time for each level
        public double expMod = 0.95f;

        //PLACEHOLDER need to pull 'years' fromm SurveyDOB.xaml.cs
        public int age = 30;




        //method for adjusting level experience modifier based on current level. The requirements for level improvement are less each level up.
        //need to determine if there is a more succint way to write this code.
        static void ExpMod (int level, double expMod)
        {
            if (level > 10)
            {
                expMod = 0.96f;
            }

            else if (level >20)
            {
                expMod = 0.97f;
            }

        }

        //method for applying handicap which factors in age 
        static void Handicap(int years, double runningTime)
        {




            if (years > 30)
            {
                runningTime = runningTime * 0.95;
            }
        }

        /*void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                GainExp(3);
            }
        }*/

        static void Leveling(int level)
        {
            double running100WR = 9.69;
            double level2 = running100WR * 2;

            //if 
        }

        //leveling methods
        /* public void GainExp(int e)
         {
             vCurrExp += e;
             if (vCurrExp >= vExpLeft)
             {
                 LvlUp();
             }
         }
         void LvlUp()
         {
             vCurrExp -= vExpLeft;
             vLevel++;
             float t = Mathf.Pow(vExpMod, vLevel);
             vExpLeft = (int)Mathf.Floor(vExpBase * t);

         } */
    }
}
