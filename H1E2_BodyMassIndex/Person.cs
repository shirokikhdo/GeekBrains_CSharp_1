namespace H1E2_BodyMassIndex
{
    public class Person
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BodyMassIndex => Weight/(Height*Height);
    }
}