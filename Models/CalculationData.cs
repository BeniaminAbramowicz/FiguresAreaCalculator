using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CalculationData
    {
        private string _inputData;
        public string InputData { get => _inputData; set => _inputData = value; }

        private string _chosenFigure;
        public string ChosenFigure { get => _chosenFigure; set => _chosenFigure = value; }
    }
}