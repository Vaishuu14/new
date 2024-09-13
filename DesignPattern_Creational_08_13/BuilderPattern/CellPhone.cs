namespace BuilderPattern
{
    public class CellPhone
    {
        private string brand;
        private string os;
        private string processor;
        private double screensize;
        private int battery;
        private int camera;

        public CellPhone(string os , string processor , double screensize , int battery,int camera , string brand)
        {
            this.os = os;
            this.processor = processor;
            this.screensize = screensize;
            this.battery = battery;
            this.camera = camera;
            this.brand = brand;
        }


        public override string ToString()
        {
            return $"OS : {os}, Processor : {processor} , Screensize : {screensize}, Battery : {battery} , Camera : {camera}";
        }

    }
}
