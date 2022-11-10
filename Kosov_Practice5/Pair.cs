﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosov_Practice5
{
    internal class Pair
    {
        private int _firstValue;
        private int _secondValue;

        public Pair(int firstValue, int secondValue)
        {
            _firstValue = firstValue;
            _secondValue = secondValue;
        }

        public int FirstValue
        {
            get => _firstValue;
            set
            {
                _firstValue = value;
            }
        }

        public int SecondValue
        {
            get => _secondValue;
            set
            {
                _secondValue = value;
            }
        }

        public bool PairCompare(Pair ParaOne, Pair ParaTwo)
        {
            if (ParaOne.FirstValue + ParaOne.SecondValue > ParaTwo.FirstValue + ParaTwo.SecondValue)
                return true;
            else 
                return false;
        }
    }
}