namespace WebApplication1.Servicies
{
    public class SimpleCalculate : ICalculate
    {
        public decimal Data { get; set; } = 0;
        public SimpleCalculate()
        {
            Data = 100;
        }

        public decimal Calculate(decimal value)
        {
            Data += value;
            return Data;
        }
    }
}
