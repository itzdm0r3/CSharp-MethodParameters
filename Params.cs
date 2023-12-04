using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodParameters
{
    public class Params
    {
        //This method should return whatever String was passed into it by whatever invoked it (in this case, the two tests in Program.cs)
        //to test the functionality of this method - it will always expect the method to return the same variable that was provided
        //to the method.

        public string copy(string text)
        {
            return text;        //"text" is a parameter passed into this method by whatever called it.
        }

    }
}
