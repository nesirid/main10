


namespace Homework_Encapsulation_Abstraction.Models
{
    internal class Car
    {
        public string name;
        public int speed;
        private string color = "red";
        public string Color {
        get
            {               
                    if (speed > 400)
                    {
                        return color;
                    }
                        return "Speed is Low";
            }
        set
            { 
                color = value;
            }
            }
    }
}
