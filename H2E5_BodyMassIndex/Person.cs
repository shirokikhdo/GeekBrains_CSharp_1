using System;

namespace H2E5_BodyMassIndex
{
    public class Person
    {
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BodyMassIndex => _setBodyMassIndex();
        public string Сonclusion => _setСonclusion();
        public double ValueConclusion { get; set; }

        private string _addWeightLine = "Необходимо набрать ";
        private string _removeWeightLine = "Необходимо похудеть на ";
        private string _kgLine = " кг.";

        private double _setBodyMassIndex()
        {
            var value = Weight / (Height * Height);
            return Math.Round(value, 2);
        }

        private string _setСonclusion()
        {
            string result;
            double normalWeight;
            if (BodyMassIndex <= 16)
            {
                result = "Выраженный дефицит массы тела" + _getLowerValue();
                return result;
            }
            if (16 < BodyMassIndex & BodyMassIndex < 18.5)
            {
                result = "Недостаточная (дефицит) масса тела" + _getLowerValue();
                return result;
            } 
            if (18.5 <= BodyMassIndex & BodyMassIndex <= 25)
            {
                result = "Норма";
                return result;
            }            
            if (25 < BodyMassIndex & BodyMassIndex <= 30)
            {
                result = "Избыточная масса тела (предожирение)" + _getUpperValue();
                return result;
            }
            if (30 < BodyMassIndex & BodyMassIndex <= 35)
            {
                result = "Ожирение первой степени" + _getUpperValue();
                return result;
            }
            if (35 < BodyMassIndex & BodyMassIndex < 40)
            {
                result = "Ожирение второй степени" + _getUpperValue();
                return result;
            }
            if (40 <= BodyMassIndex)
            {
                result = "Ожирение третьей степени(морбидное)" + _getUpperValue();
                return result;
            }
            else
            {
                result = "Что-то не так";
            }
            return result;
        }

        private string _getLowerValue()
        {
            var normalWeight = 18.5 * Height * Height;
            ValueConclusion = normalWeight - Weight;
            var line = $"\n{_addWeightLine}{ValueConclusion}{_kgLine}";
            return line;
        }

        private string _getUpperValue()
        {
            var normalWeight = 25 * Height * Height;
            ValueConclusion = Weight - normalWeight;
            var line = $"\n{_removeWeightLine}{ValueConclusion}{_kgLine}";
            return line;
        }
    }
}