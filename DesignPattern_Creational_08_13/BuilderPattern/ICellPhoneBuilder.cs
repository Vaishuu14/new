using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
     public interface ICellPhoneBuilder
    {
        CellPhone GetPhone();
        ICellPhoneBuilder SetBattery(int battery);
        ICellPhoneBuilder SetProcessor(string processor);
        ICellPhoneBuilder SetOS(string os);
        ICellPhoneBuilder SetScreenSize(double screenSize);
        ICellPhoneBuilder SetCamera(int camera);


    }
}
