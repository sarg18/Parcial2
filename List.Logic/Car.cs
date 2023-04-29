namespace Lists.Logic
{
    public class Car
    {
        public string? Brand { get; set; }

        public String? Model { get; set; }

        public int Year  { get; set; }
        public decimal Price { get; set; }
        public string? Color { get; set; }


        public override string ToString()
        {
            return $"{Brand} - {Price:C2} - {Model} - {Year} - {Color} ";
        }
    }
}