namespace BuilderPattern
{
    public class SamsungPhoneBuilder : ICellPhoneBuilder
    {
        private string brand = "Samsung";
        public string os;
        private string processor;
        private double screensize;
        private int battery;
        private int camera;

        public CellPhone GetPhone()
        {
            return new CellPhone(os, processor, screensize, battery, camera,brand);
        }

        public ICellPhoneBuilder SetOS(string os)
        {
            this.os = os;
            return this;
        }
        public ICellPhoneBuilder SetProcessor(string processor)
        {
            this.processor = processor;
            return this;
        }
        public ICellPhoneBuilder SetScreenSize(double screensize)
        {
            this.screensize = screensize;
            return this;
        }
        public ICellPhoneBuilder SetBattery(int battery)
        {
            this.battery = battery;
            return this;
        }
        public ICellPhoneBuilder SetCamera(int camera)
        {
            this.camera = camera;
            return this;
        }




    }
}
